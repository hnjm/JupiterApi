using System.Threading.Tasks;
using Jupiter.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.WebApi.Controllers
{
    public class UserController : SiteBaseController
    {

        #region constructor

        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        #endregion

        #region users list

        [HttpGet("Users")]
        public async Task<IActionResult> Users()
        {
            return new ObjectResult(await userService.GetAllUsers());
        }

        #endregion

    }
}