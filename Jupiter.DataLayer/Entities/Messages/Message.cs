using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jupiter.DataLayer.Entities.Messages
{
   public class Message : BaseEntity
    {

        #region properties

        public long? UserId { get; set; }

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

        #endregion


        #region relations

        [Required]
        public User User { get; set; }

        public ICollection<MessageVisit> MessageVisits { get; set; }
        public ICollection<MessageSelectedCategory> ProductSelectedCategories { get; set; }
        public ICollection<MessageComment> MessageComments { get; set; }

        #endregion

    }
}
