using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new { Message = "Сервер работает!" };
            return Ok(response);
        }
    }
}
