using DiscountSubSystem;
using ERP;
using Xunit;

namespace AssignmentTests
{
    public class OrderDiscountCalculator_Test
    {
        [Fact]
        public void OrderDiscountCalculator_Calculates_Null_Success()
        {
            Order order = null;
            var calculator = new OrderDiscountCalculator();
            var calcResult = calculator.Calculate(order);
            Assert.Null(calcResult);
        }

        [Fact]
        public void OrderDiscountCalculator_Calculates_Success()
        {
            var order = new Order(new Customer("Jim ", "Pireaus")) { CatalogPrice = 1200 };
            var calculator = new OrderDiscountCalculator();
            var calcResult = calculator.Calculate(order);
            Assert.True(calcResult?.Count() == 1);
            Assert.Contains(calcResult, c => c.Name == new CatalogPriceDiscount().Name);
            Assert.Contains(calcResult, c => c.SortOrder == new CatalogPriceDiscount().SortOrder);
            Assert.Contains(calcResult, c => c.DiscountValue == order.CatalogPrice * 5 / 100);
        }

        [Fact]
        public void CalculateDiscountResults_Success()
        {
            var order = new Order(new Customer("Dimitris Pappas", "Athens")) { CatalogPrice = 1200 };
            var calculator = new OrderDiscountCalculator();
            var discounts = new List<IDiscount> { new CatalogPriceDiscount(), new PromotionDiscount(), new CouponDiscount() };
            var calcResult = calculator.CalculateDiscountResults(order, discounts);
            Assert.True(calcResult?.Count() == 3);
            Assert.Contains(calcResult, c => c.Name == new CatalogPriceDiscount().Name);
            Assert.Contains(calcResult, c => c.SortOrder == new CatalogPriceDiscount().SortOrder);
            Assert.Contains(calcResult, c => c.DiscountValue == order.CatalogPrice * 5 / 100);
            Assert.Contains(calcResult, c => c.Name == new PromotionDiscount().Name);
            Assert.Contains(calcResult, c => c.SortOrder == new PromotionDiscount().SortOrder);
            Assert.Contains(calcResult, c => c.DiscountValue == order.CatalogPrice * 10 / 100);
            Assert.Contains(calcResult, c => c.Name == new CouponDiscount().Name);
            Assert.Contains(calcResult, c => c.SortOrder == new CouponDiscount().SortOrder);
            Assert.Contains(calcResult, c => c.DiscountValue == 10);

        }

        [Fact]
        public void GetApplicableDiscounts_CatalogPrice_Success()
        {
            var order = new Order(new Customer("Jim Pappas", "Pireaus")) { CatalogPrice = 1200 };
            var calculator = new OrderDiscountCalculator();
            var discounts = calculator.GetApplicableDiscounts(order);
            Assert.True(discounts?.Count() == 1);
            Assert.Contains(discounts, c => c is CatalogPriceDiscount);
        }

        [Fact]
        public void GetApplicableDiscounts_Promotion_Success()
        {
            var order = new Order(new Customer("Jim Pappas", "Athens")) { CatalogPrice = 200 };
            var calculator = new OrderDiscountCalculator();
            var discounts = calculator.GetApplicableDiscounts(order);
            Assert.True(discounts?.Count() == 1);
            Assert.Contains(discounts, c => c is PromotionDiscount);
        }

        [Fact]
        public void GetApplicableDiscounts_Coupon_Success()
        {
            var order = new Order(new Customer("Dimitris Pappas", "Pireaus")) { CatalogPrice = 200 };
            var calculator = new OrderDiscountCalculator();
            var discounts = calculator.GetApplicableDiscounts(order);
            Assert.True(discounts?.Count() == 1);
            Assert.Contains(discounts, c => c is CouponDiscount);
        }

        [Fact]
        public void GetApplicableDiscounts_AllTypes_Success()
        {
            var order = new Order(new Customer("Dimitris Pappas", "Athens")) { CatalogPrice = 1200 };
            var calculator = new OrderDiscountCalculator();
            var discounts = calculator.GetApplicableDiscounts(order);
            Assert.True(discounts?.Count() == 3);
            Assert.Contains(discounts, c => c is CatalogPriceDiscount);
            Assert.Contains(discounts, c => c is PromotionDiscount);
            Assert.Contains(discounts, c => c is CouponDiscount);
        }
    }
}