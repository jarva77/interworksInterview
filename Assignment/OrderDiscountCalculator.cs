using DiscountSubSystem;
using ERP;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo( "AssignmentTests")]
namespace ERP
{

    public class OrderDiscountCalculator : IOrderDiscountCalculator
    {
        internal IEnumerable<IDiscount>? GetApplicableDiscounts(Order order)
        {
            if (order == null)
                return null;

            return new List<IDiscount?>() {
                order.CatalogPrice > 1000 ? new CatalogPriceDiscount() : null,
                order.Customer.Address.Contains("Athens") ? new PromotionDiscount() : null,
                order.Customer.Name.Contains("Dimitris") ? new CouponDiscount() : null
                }.Where(x => x != null).Cast<IDiscount>();
            ;
        }

        internal IEnumerable<DiscountResult>? CalculateDiscountResults(Order order, IEnumerable<IDiscount>? discounts)
        {
            return discounts?.Select(c => c.Apply(order)).OrderBy(c => c.SortOrder).ToList();
        }

        public IEnumerable<DiscountResult>? Calculate(Order order)
        {
            var discounts = GetApplicableDiscounts(order);
            return CalculateDiscountResults(order, discounts);

        }
    }

}
