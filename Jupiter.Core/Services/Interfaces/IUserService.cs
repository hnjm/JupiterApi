using Jupiter.DataLayer.Entities.Account;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<List<User>> GetAllUsers();
    }
}
