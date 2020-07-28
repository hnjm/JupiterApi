using Jupiter.Core.DTOs.Account;
using Jupiter.Core.DTOs.User;
using Jupiter.Core.Security;
using Jupiter.Core.Services.Interfaces;
using Jupiter.Core.Utilities.Convertors;
using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Jupiter.DataLayer.Entities.Access;

namespace Jupiter.Core.Services.Implementations
{
    public class UserService : IUserService
    {
        #region constructor

        private readonly IWebHostEnvironment webHostEnviroment;

        private IGenericRepository<User> userRepository;
        private IGenericRepository<UserRole> userRoleRepository;
        private IGenericRepository<Role> roleRepository;
        private IPasswordHelper passwordHelper;
        private IMailSender mailSender;
        private IViewRenderService renderView;

        public UserService(IGenericRepository<User> userRepository, IPasswordHelper passwordHelper, IMailSender mailSender, IViewRenderService renderView, IWebHostEnvironment webHostEnviroment, IGenericRepository<UserRole> userRoleRepository, IGenericRepository<Role> roleRepository)
        {
            this.userRepository = userRepository;
            this.passwordHelper = passwordHelper;
            this.mailSender = mailSender;
            this.renderView = renderView;
            this.webHostEnviroment = webHostEnviroment;
            this.userRoleRepository = userRoleRepository;
            this.roleRepository = roleRepository;
        }

        #endregion

        #region User Section

        public async Task<List<UserDTO>> GetAllUsers()
        {

            return await userRepository.GetEntitiesQuery().Select(s => new UserDTO()
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Gender = s.Gender,
                Email = s.Email,
                Avatar = s.Avatar,
                CreateDate = s.CreateDate,
                MobileNumber = s.MobileNumber,
                Dateofbirth = s.DateOfBirth,
                IsActivated = s.IsActivated,
                IsDelete = s.IsDelete,
                LastUpdateDate = s.LastUpdateDate,
                MembershipNumber = s.MembershipNumber,
                NationalCode = s.NationalCode,
            }).ToListAsync();
        }

        public async Task<RegisterUserResult> RegisterUser(RegisterUserDTO register)
        {
            if (IsUserExistsByEmail(register.Email))
                return RegisterUserResult.EmailExists;

            var user = new User
            {
                Email = register.Email.SanitizeText(),
                FirstName = register.FirstName.SanitizeText(),
                LastName = register.LastName.SanitizeText(),
                Avatar = register.Avatar,
                DateOfBirth = DateTime.ParseExact(register.DateOfBirth, "yyyy/MM/dd", CultureInfo.InvariantCulture),
                Gender = register.Gender,
                MembershipNumber = register.MembershipNumber.SanitizeText(),
                MobileNumber = register.MobileNumber.SanitizeText(),
                NationalCode = register.NationalCode.SanitizeText(),
                EmailActiveCode = Guid.NewGuid().ToString("N").Substring(0, 8),
                Password = passwordHelper.EncodePasswordMd5(register.Password)
            };

            await userRepository.AddEntity(user);
            await userRepository.SaveChanges();

            var role = new UserRole
            {
                UserId = user.Id,
                RoleId = 3
            };

            await userRoleRepository.AddEntity(role);
            await userRoleRepository.SaveChanges();

            var body = await renderView.RenderToStringAsync("Email/ActivateAccount", user);

            mailSender.Send(user.Email, "فعال سازی حساب کاربری", body);

            return RegisterUserResult.Success;
        }

        public bool IsUserExistsByEmail(string email)
        {
            return userRepository.GetEntitiesQuery().Any(s => s.Email == email.ToLower().Trim());
        }

        public async Task<LoginUserResult> LoginUser(LoginUserDTO login)
        {
            var password = passwordHelper.EncodePasswordMd5(login.Password);

            var user = await userRepository.GetEntitiesQuery()
                .SingleOrDefaultAsync(s => s.Email == login.Email.ToLower().Trim() && s.Password == password);

            if (user == null) return LoginUserResult.IncorrectData;

            if (!user.IsActivated) return LoginUserResult.NotActivated;

            return LoginUserResult.Success;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await userRepository.GetEntitiesQuery().SingleOrDefaultAsync(s => s.Email == email.ToLower().Trim());
        }

        public async Task<User> GetUserByUserId(long userId)
        {
            return await userRepository.GetEntityById(userId);
        }

        public void ActivateUser(User user)
        {
            user.IsActivated = true;
            user.EmailActiveCode = Guid.NewGuid().ToString();
            userRepository.UpdateEntity(user);
            userRepository.SaveChanges();
        }

        public Task<User> GetUserByEmailActiveCode(string emailActiveCode)
        {
            return userRepository.GetEntitiesQuery().SingleOrDefaultAsync(s => s.EmailActiveCode == emailActiveCode);
        }
        public Task<string> GetUserRoleById(long userId)
        {
            return userRoleRepository.GetEntitiesQuery()
                .Include(s => s.Role)
                .Where(w => w.UserId == userId )
                .Select(s => s.Role.Name.ToString()).FirstOrDefaultAsync();
        }



        #endregion

        #region dispose

        public void Dispose()
        {
            userRepository?.Dispose();
        }

        #endregion
    }
}
