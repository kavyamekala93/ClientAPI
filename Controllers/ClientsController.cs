using Microsoft.AspNetCore.Mvc;

namespace ClientAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClients()
        {
            var clients = new[]
            {
                new { Id = 1, Name = "John Smith", Advisor = "Sarah" },
                new { Id = 2, Name = "Mary Jones", Advisor = "David" }
            };

            return Ok(clients);
        }
    }
}