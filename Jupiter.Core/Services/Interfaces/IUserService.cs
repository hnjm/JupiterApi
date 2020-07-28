using Jupiter.Core.DTOs.Account;
using Jupiter.Core.DTOs.User;
using Jupiter.DataLayer.Entities.Access;
using Jupiter.DataLayer.Entities.Account;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<List<UserDTO>> GetAllUsers();
        Task<RegisterUserResult> RegisterUser(RegisterUserDTO register);
        bool IsUserExistsByEmail(string email);
        Task<LoginUserResult> LoginUser(LoginUserDTO login);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByUserId(long userId);
        void ActivateUser(User user);
        Task<User> GetUserByEmailActiveCode(string emailActiveCode);
        Task<string> GetUserRoleById(long userId);
    }
}
