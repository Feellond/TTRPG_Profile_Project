using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [ApiController]
    [Route("api/item")]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {

            return Ok();
        }
    }
}
