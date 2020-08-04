using Jupiter.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.DataLayer.Entities.Messages
{
    public class MessageVisit : BaseEntity
    {

        #region properties

        public long? MessageId { get; set; }

        [Display(Name = "IP")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string UserID { get; set; }

        #endregion

        #region relations

        public Message Message { get; set; }

        #endregion

    }
}
