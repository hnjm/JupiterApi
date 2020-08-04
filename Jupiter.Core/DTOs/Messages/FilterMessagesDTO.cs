using Jupiter.Core.DTOs.Paging;
using Jupiter.Core.DTOs.User;
using Jupiter.DataLayer.Entities.Messages;
using System.Collections.Generic;

namespace Jupiter.Core.DTOs.Messages
{
    public class FilterMessagesDTO : BasePaging
    {

        public string Title { get; set; }

        public List<MessagesDTO> Messages { get; set; }

        public List<long> Categories { get; set; }


        public FilterMessagesDTO SetPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.PageCount = paging.PageCount;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.TakeEntity = paging.TakeEntity;
            this.SkipEntity = paging.SkipEntity;
            this.ActivePage = paging.ActivePage;
            return this;
        }

        public FilterMessagesDTO SetMessages(List<MessagesDTO> Messages)
        {
            this.Messages = Messages;
            return this;
        }


    }
}
