using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TTRPG_Project.Web.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {

    }
}
