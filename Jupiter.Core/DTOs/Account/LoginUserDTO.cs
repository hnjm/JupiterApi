using System.ComponentModel.DataAnnotations;

namespace Jupiter.Core.DTOs.Account
{
    public class LoginUserDTO
    {
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
    }

    public enum LoginUserResult
    {
        Success,
        IncorrectData,
        NotActivated
    }
}
