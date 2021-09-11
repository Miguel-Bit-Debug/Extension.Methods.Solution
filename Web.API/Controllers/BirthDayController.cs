using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.API.Extension.Methods;

namespace Web.API.Controllers
{
    [Route("v1/api")]
    public class BirthDayController : Controller
    {
        [HttpGet("birthday")]
        public IActionResult Index()
        {
            var birthDay = new DateTime().BirthDay(04, 03, 2001);
            return Ok(birthDay);
        }
    }
}
