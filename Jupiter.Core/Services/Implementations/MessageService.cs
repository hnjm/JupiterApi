using Jupiter.Core.Services.Interfaces;
using Jupiter.DataLayer.Entities.Message;
using Jupiter.DataLayer.Repository;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Implementations
{
    public class MessageService : IMessageService
    {

        #region constructor

        private IGenericRepository<Message> messageRepository;
        private IGenericRepository<MessageCategory> messageCategoryRepository;
        private IGenericRepository<MessageComment> messageCommentRepository;
        private IGenericRepository<MessageSelectedCategory> messageSelectedCategoryRepository;
        private IGenericRepository<MessageVisit> messageVisitRepository;

        public MessageService(IGenericRepository<Message> messageRepository, IGenericRepository<MessageCategory> messageCategoryRepository, IGenericRepository<MessageComment> messageCommentRepository, IGenericRepository<MessageSelectedCategory> messageSelectedCategoryRepository, IGenericRepository<MessageVisit> messageVisitRepository)
        {
            this.messageRepository = messageRepository;
            this.messageCategoryRepository = messageCategoryRepository;
            this.messageCommentRepository = messageCommentRepository;
            this.messageCommentRepository = messageCommentRepository;
            this.messageVisitRepository = messageVisitRepository;
        }

        #endregion



        public async Task AddMessage(Message message)
        {
            await messageRepository.AddEntity(message);
            await messageRepository.SaveChanges();
        }

        public async Task UpdateMessage(Message message)
        {
            messageRepository.UpdateEntity(message);
            await messageRepository.SaveChanges();
        }


        #region dispose

        public void Dispose()
        {
            messageRepository?.Dispose();
            messageCategoryRepository?.Dispose();
            messageCommentRepository?.Dispose();
            messageSelectedCategoryRepository?.Dispose();
            messageVisitRepository?.Dispose();
        }

        #endregion

    }
}
