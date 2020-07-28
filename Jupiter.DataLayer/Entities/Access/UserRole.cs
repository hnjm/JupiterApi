using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jupiter.DataLayer.Entities.Access
{
    public class UserRole: BaseEntity
    {
        #region properties

        public long UserId { get; set; }

        public long RoleId { get; set; }

        #endregion

        #region Relations

        public User User { get; set; }

        public Role Role { get; set; }

        #endregion

    }
}
