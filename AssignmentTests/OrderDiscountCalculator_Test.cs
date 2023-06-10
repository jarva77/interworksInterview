using DiscountSubSystem;
using ERP;
using Xunit;

namespace AssignmentTests
{
    [Trait("OrderDiscountCalculator", "OrderDiscountCalculator")]
    public class OrderDiscountCalculator_Test
    {

        [Fact]
        public void OrderDiscountCalculator_Calculates()
        {
            var order = new Order(new Customer("Jim ", "Pireaus")) { CatalogPrice = 1200 };
            var calculator = new OrderDiscountCalculator();
            //TODO: Add relevant tests
            var discounts = calculator.GetApplicableDiscounts(order);
            var calcResult = calculator.CalculateDiscountResults(order , discounts);

            
        }

    }
}