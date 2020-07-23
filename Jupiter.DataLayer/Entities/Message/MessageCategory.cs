using Jupiter.DataLayer.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jupiter.DataLayer.Entities.Message
{
    public class MessageCategory : BaseEntity
    {
        #region Properties

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Title { get; set; }

        [Display(Name = "عنوان لینک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string UrlTitle { get; set; }

        public long? ParentId { get; set; }


        #endregion

        #region Relations

        [ForeignKey("ParentId")]
        public MessageCategory ParentCategory { get; set; }

        public ICollection<MessageSelectedCategory> MessageSelectedCategories { get; set; }

        #endregion
    }
}
