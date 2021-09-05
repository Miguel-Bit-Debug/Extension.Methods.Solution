using Microsoft.AspNetCore.Mvc;
using Web.API.Calculator;
using Web.API.Extension.Methods;

namespace Web.API.Controllers
{
    [Route("v1/api")]
    public class CalculateController : ControllerBase
    {
        [HttpGet("calc")]
        public IActionResult Index()
        {
            var calc = new CalculatePrice();
            var totoalPRice = calc.TotalPrice(5, 8);

            return Ok($"Totla Price {totoalPRice}");
        }

        [HttpGet("calc/discount")]
        public IActionResult CalcDiscount()
        {
            var calc = new CalculatePrice();
            var priceWithDiscount = calc.CalculatePriceWithDiscount(5, 8, 2);

            return Ok($"Total Price With Discount {priceWithDiscount}");
        }
    }
}
