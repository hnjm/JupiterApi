using Jupiter.Core.Services.Interfaces;
using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Implementations
{
    public class UserService : IUserService
    {
        #region constructor

        private IGenericRepository<User> userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        #endregion

        #region User Section

        public async Task<List<User>> GetAllUsers()
        {
            return await userRepository.GetEntitiesQuery().ToListAsync();
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
