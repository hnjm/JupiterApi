using Jupiter.DataLayer.Entities.Access;
using Jupiter.DataLayer.Entities.Common;
using Jupiter.DataLayer.Entities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.DataLayer.Entities.Account
{
    public class User : BaseEntity
    {

        #region properties

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(3, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(3, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string LastName { get; set; }

        [Display(Name = "شماره دانشجویی / استادی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(12, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string MembershipNumber { get; set; }

        [Display(Name = "تصویر کاربر")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string? Avatar { get; set; }

        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(10, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string NationalCode { get; set; }

        [Display(Name = "شماره تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(13, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string MobileNumber { get; set; }

        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool Gender { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(320, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(6, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(6, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        public string Password { get; set; }

        [MaxLength(8, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")] public string EmailActiveCode { get; set; }
        public bool IsActivated { get; set; }

        #endregion

        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<MessageComment> MessageComments { get; set; }
        public ICollection<Message> Messages { get; set; }

        #endregion

    }
}
