using Jupiter.Core.DTOs.Messages;
using Jupiter.DataLayer.Entities.Messages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Interfaces
{
    public interface IMessageService : IDisposable
    {

        #region Message

        Task AddMessage(Message message);
        Task UpdateMessage(Message message);
        Task<FilterMessagesDTO> FilterMessages(FilterMessagesDTO filter);
        Task<Message> GetMessageById(long messageId);
        Task<List<GetAllMessagesDTO>> GetAllMessages();

        #endregion

        #region product categories

        Task<List<MessageCategory>> GetAllActiveMessageCategories();

        #endregion

    }
}
