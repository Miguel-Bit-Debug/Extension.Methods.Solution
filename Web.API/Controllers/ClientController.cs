using Microsoft.AspNetCore.Mvc;
using Web.API.Extension.Methods;
using Web.API.Models;

namespace Web.API.Controllers
{
    [Route("v1/api")]
    public class ClientController : ControllerBase
    {
        [HttpGet("client")]
        public IActionResult Index()
        {
            var client = new ClientModel()
            {
                Name = "Cliente".ClientNameUpperCase()
            };

            return Ok(client);
        }
    }
}
