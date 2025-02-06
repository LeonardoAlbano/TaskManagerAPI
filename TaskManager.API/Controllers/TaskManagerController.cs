using Microsoft.AspNetCore.Mvc;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Created();
        }
    }
}
