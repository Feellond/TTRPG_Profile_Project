using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.Services.Items;

namespace TTRPG_Project.Web.Controllers
{
    //[Authorize(Roles = nameof(Roles.MODERATOR) + "," + nameof(Roles.ADMINISTRATOR))]
    [Authorize]
    [ApiController]
    [Route("api/creatures")]
    public class CreatureController : ControllerBase
    {
        
    }
}
