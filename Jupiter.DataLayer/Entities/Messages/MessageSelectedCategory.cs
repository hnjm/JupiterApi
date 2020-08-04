using Jupiter.DataLayer.Entities.Common;

namespace Jupiter.DataLayer.Entities.Messages
{
    public class MessageSelectedCategory : BaseEntity
    {

        #region Properties

        public long MessageId { get; set; }

        public long MessageCategoryId { get; set; }

        #endregion

        #region Relations

        public Message Message { get; set; }

        public MessageCategory MessageCategory { get; set; }

        #endregion

    }
}
