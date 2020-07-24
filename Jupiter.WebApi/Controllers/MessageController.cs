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
        public async Task<IActionResult> GetProducts([FromQuery]FilterMessagesDTO filter)
        {
            var products = await messageService.FilterMessages(filter);

            return JsonResponseStatus.Success(products);
        }

        #endregion



    }
}