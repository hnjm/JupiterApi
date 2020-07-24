using System.Threading.Tasks;
using Jupiter.Core.DTOs.Messages;
using Jupiter.Core.Services.Interfaces;
using Jupiter.Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.WebApi.Controllers
{
    public class MessageController : SiteBaseController
    {

        #region constructor

        private IMessageService messageService;
        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        #endregion

        #region Messages

        [HttpGet("filter-messages")]
        public async Task<IActionResult> GetMessages([FromQuery]FilterMessagesDTO filter)
        {
            var products = await messageService.FilterMessages(filter);

            return JsonResponseStatus.Success(products);
        }

        #endregion

        #region get message categories

        [HttpGet("message-active-categories")]
        public async Task<IActionResult> GetMessagesCategories()
        {
            return JsonResponseStatus.Success(await messageService.GetAllActiveMessageCategories());
        }

        #endregion

        #region get single message

        [HttpGet("single-message/{id}")]
        public async Task<IActionResult> GetMessage(long id)
        {
            var message = await messageService.GetMessageById(id);

            if (message != null)
                return JsonResponseStatus.Success(message);

            return JsonResponseStatus.NotFound();
        }

        #endregion

    }
}