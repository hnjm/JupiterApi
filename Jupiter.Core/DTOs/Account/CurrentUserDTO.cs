using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Core.DTOs.Account
{
    class CurrentUserDTO
    {
        public string token { get; set; }
        public int expireTime { get; set; }
        public long userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string avatar { get; set; }
    }
}
