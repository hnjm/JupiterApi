using Jupiter.DataLayer.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.DataLayer.Entities.Message
{
   public class Message : BaseEntity
    {

        #region properties

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10000, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Auther { get; set; }


        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Description { get; set; }

        [Display(Name = "پسندیدن")]
        public int? Like { get; set; }

        [Display(Name = "نپسندیدن")]
        public int? DisLike { get; set; }


        [Display(Name = "مهم")]
        public bool IsImportant { get; set; }


        #endregion

        #region relations

        public ICollection<MessageVisit> MessageVisits { get; set; }
        public ICollection<MessageSelectedCategory> ProductSelectedCategories { get; set; }
        public ICollection<MessageComment> MessageComments { get; set; }


        #endregion

    }
}
