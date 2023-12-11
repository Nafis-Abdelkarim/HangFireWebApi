using Microsoft.AspNetCore.Mvc;

namespace HangFireWebApi7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangfireController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello from hangfire web api");
        }
    }
}