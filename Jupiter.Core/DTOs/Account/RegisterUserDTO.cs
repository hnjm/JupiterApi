using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.Core.DTOs.Account
{
    public class RegisterUserDTO
    {
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
        public string Avatar { get; set; }

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
        public string DateOfBirth { get; set; }

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

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(6, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند کمتر از {2} باشد")]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string ConfirmPassword { get; set; }



    }

    public enum RegisterUserResult
    {
        Success,
        EmailExists
    }
}
