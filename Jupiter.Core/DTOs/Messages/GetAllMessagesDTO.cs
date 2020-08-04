using Jupiter.Core.DTOs.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jupiter.Core.DTOs.Messages
{
   public class GetAllMessagesDTO
    {

        public long Id { get; set; }
        public DateTime CreateDate { get; set; }

        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorAvatar { get; set; }
        public string AuthorMembershipNumber { get; set; }
        public bool AuthorGender { get; set; }


        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10000, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string text { get; set; }

        [Display(Name = "پسندیدن")]
        public int? Like { get; set; }

        [Display(Name = "نپسندیدن")]
        public int? DisLike { get; set; }

        [Display(Name = "مهم")]
        public bool? IsImportant { get; set; }

    }
}
