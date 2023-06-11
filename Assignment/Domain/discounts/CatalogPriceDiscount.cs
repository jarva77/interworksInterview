
namespace ERP.Domain
{
    public class CatalogPriceDiscount : BaseEntity<int>, IDiscount
    {
        public string Name { get => "Price List"; }
        public int SortOrder { get => 10; }

        public DiscountType Type => DiscountType.Percentage;

        public DiscountResult Apply(Order order)
        {
            return new DiscountResult(this.Name, (order.CatalogPrice * 5 / 100), this.SortOrder);
        }
    }

}
