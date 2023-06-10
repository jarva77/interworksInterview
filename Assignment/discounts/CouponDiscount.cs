using ERP;

namespace DiscountSubSystem
{
    public class CouponDiscount : IDiscount
    {
        public string Name { get => "Coupon"; }
        public int SortOrder { get => 30; }
        public DiscountType Type => DiscountType.Amount;
        public DiscountResult Apply(Order order)
        {
            return new DiscountResult(this.Name, 10, this.SortOrder);
        }
    }

}
