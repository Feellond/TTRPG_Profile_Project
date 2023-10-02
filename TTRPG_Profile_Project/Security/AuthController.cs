using Microsoft.AspNetCore.Mvc;

namespace TTRPG_Project.Web.Security
{
    [Route("api/security")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("success");
        }
    }
}
