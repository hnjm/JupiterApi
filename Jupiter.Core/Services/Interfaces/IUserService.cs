﻿using Jupiter.Core.DTOs.Account;
using Jupiter.DataLayer.Entities.Account;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<List<User>> GetAllUsers();
        Task<RegisterUserResult> RegisterUser(RegisterUserDTO register);
        bool IsUserExistsByEmail(string email);
        Task<LoginUserResult> LoginUser(LoginUserDTO login);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByUserId(long userId);
    }
}
