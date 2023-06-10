using DiscountSubSystem;
using ERP;
using Xunit;

namespace AssignmentTests
{
    [Trait("PromotionDiscount", "PromotionDiscount")]
    public class PromotionDiscount_Test
    {

        [Fact]
        public void PromotionDiscount_Calculates()
        {
            var order = new Order(new Customer("Jim ", "Pireaus")) { CatalogPrice = 1200 };
            var discount = new PromotionDiscount();

            var  result = discount.Apply(order);

            Assert.Equal(120, result.DiscountValue);
            Assert.Equal(20, result.SortOrder);   
        }

    }
}