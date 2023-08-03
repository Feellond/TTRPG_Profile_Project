using Microsoft.AspNetCore.Mvc;

namespace RankingApp.Security
{
    [Route("")]
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
