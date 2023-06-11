using DiscountSubSystem;
using ERP;
using Xunit;

namespace AssignmentTests
{
    public class CouponDiscount_Test
    {
        [Fact]
        public void CouponDiscount_Calculates()
        {
            var order = new Order(new Customer("Jim ", "Pireaus")) { CatalogPrice = 1200 };
            var discount = new CouponDiscount();
            var result = discount.Apply(order);
            Assert.Equal(10, result.DiscountValue);
            Assert.Equal(30, result.SortOrder);
        }
    }
}