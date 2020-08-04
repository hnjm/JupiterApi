using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jupiter.DataLayer.Entities.Messages
{
    public class MessageComment : BaseEntity
    {

        #region properties

        public long? MessageId { get; set; }

        public long? ParentId { get; set; }

        public long? UserId { get; set; }

        [Display(Name = "نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10000, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Text { get; set; }

        #endregion

        #region relations
        public Message Message { get; set; }
        public User User { get; set; }

        [ForeignKey("ParentId")]
        public MessageComment ParentComment { get; set; }

        #endregion

    }
}
