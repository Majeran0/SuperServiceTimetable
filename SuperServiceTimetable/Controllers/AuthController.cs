using Microsoft.AspNetCore.Mvc;

namespace SuperServiceTimetable.API.Controllers
{
    public class AuthController :ControllerBase
    {
        public AuthController()
        {
            
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(string login, string password)
        {

            return Ok();
        }
    }
}
