using DiscountSubSystem;
using ERP;
using Xunit;

namespace AssignmentTests
{
    [Trait("CatalogPriceDiscount", "CatalogPriceDiscount")]
    public class CatalogPriceDiscount_Test
    {

        [Fact]
        public void CatalogPriceDiscount_Calculates()
        {
            var order = new Order(new Customer("Jim ", "Pireaus")) { CatalogPrice = 1200 };
            var discount = new CatalogPriceDiscount();

            var  result = discount.Apply(order);

            Assert.Equal(60, result.DiscountValue);
            Assert.Equal(10, result.SortOrder);   
        }

    }
}