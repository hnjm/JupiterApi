using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.DataLayer.Entities.Access
{
    public class Role : BaseEntity
    {
        #region Properties

        [Display(Name = "نام سیستمی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Name { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Title { get; set; }

        #endregion

        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }

        #endregion
    }
}
