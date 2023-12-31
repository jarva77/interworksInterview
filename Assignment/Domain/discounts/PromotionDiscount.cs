﻿

namespace ERP.Domain
{
    public class PromotionDiscount : BaseEntity<int> , IDiscount
    {
        public string Name { get => "Promotion"; }
        public int SortOrder { get => 20; }
        public DiscountType Type => DiscountType.Percentage;
        public DiscountResult Apply(Order order)
        {
            return new DiscountResult(this.Name, (order.CatalogPrice * 10 / 100), this.SortOrder);
        }
    }

}
