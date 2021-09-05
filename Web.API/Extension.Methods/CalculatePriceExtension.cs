using Web.API.Calculator;

namespace Web.API.Extension.Methods
{
    public static class CalculatePriceExtension
    {
        public static int CalculatePriceWithDiscount(this CalculatePrice calculate, int amout, int cost, int discount)
        {
            var priceWithDiscount = calculate.TotalPrice(amout, cost) - discount ;
            return priceWithDiscount;
        }
    }
}
