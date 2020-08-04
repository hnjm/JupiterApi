using Jupiter.Core.DTOs.Messages;
using Jupiter.Core.DTOs.Paging;
using Jupiter.Core.Services.Interfaces;
using Jupiter.Core.Utilities.Paging;
using Jupiter.DataLayer.Entities.Messages;
using Jupiter.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        #region Message

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

        public async Task<FilterMessagesDTO> FilterMessages(FilterMessagesDTO filter)
        {
            var messagesQuery = messageRepository.GetEntitiesQuery().Where(w => w.IsDelete == false).AsQueryable();

            if (!string.IsNullOrEmpty(filter.Title))
                messagesQuery = messagesQuery.Where(s => s.text.Contains(filter.Title));

            if (filter.Categories != null && filter.Categories.Any())
                messagesQuery = messagesQuery.SelectMany(s =>
                        s.ProductSelectedCategories.Where(f => filter.Categories.Contains(f.MessageCategoryId)).Select(t => t.Message));

            var count = (int)Math.Ceiling(messagesQuery.Count() / (double)filter.TakeEntity);

            var pager = Pager.Build(count, filter.PageId, filter.TakeEntity);

            var messages = await messagesQuery.Paging(pager).Select(s => new MessagesDTO {
            text = s.text,
            Like = s.Like,
            IsImportant = s.IsImportant,
            DisLike = s.DisLike,
            AuthorAvatar = s.User.Avatar,
            AuthorFirstName = s.User.FirstName,
            AuthorLastName = s.User.LastName,
            AuthorGender = s.User.Gender,
            AuthorMembershipNumber = s.User.MembershipNumber
            }).ToListAsync();

            return filter.SetMessages(messages).SetPaging(pager);
        }

        public async Task<Message> GetMessageById(long messageId)
        {
            return await messageRepository.GetEntityById(messageId);
        }

        public async Task<List<GetAllMessagesDTO>> GetAllMessages()
        {
            return await messageRepository.GetEntitiesQuery()
                .Include(u => u.User)
                .Select(s => new GetAllMessagesDTO { 
                    CreateDate = s.CreateDate,
                    DisLike = s.DisLike,
                    Id = s.Id,
                    IsImportant = s.IsImportant,
                    Like = s.Like,
                    text = s.text,
                    AuthorAvatar =s.User.Avatar,
                    AuthorFirstName = s.User.FirstName,
                    AuthorLastName = s.User.LastName,
                    AuthorGender = s.User.Gender,
                    AuthorMembershipNumber = s.User.MembershipNumber
                })
                .ToListAsync();
        }

        #endregion

        #region Message categories

        public async Task<List<MessageCategory>> GetAllActiveMessageCategories()
        {
            return await messageCategoryRepository.GetEntitiesQuery().Where(s => !s.IsDelete).ToListAsync();
        }

        #endregion


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
