using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces
{
    internal interface IDiscount
    {
        DiscountResult Apply(Order order);
        int SortOrder { get; }
    }

    class DiscountResult
    {
        public Decimal DiscountValue { get; set; }
        public int SortOrder { get; set; }
    }

    class Order
    {
        public decimal CatalogPrice { get; set; }
        public decimal FinalPrice { get; set; }

    }


    class CatalogPriceDiscount : IDiscount
    {
        public decimal DiscountValue { get; }
        public int SortOrder { get => 1; }

        public DiscountResult Apply(Order order)
        {
            // mocking
            return new DiscountResult { DiscountValue = (order.CatalogPrice * 5 / 100), SortOrder = this.SortOrder };
        }
    }

    class PromotionDiscount : IDiscount
    {
        public decimal DiscountValue { get; set; }
        public int SortOrder { get => 2; }

        public DiscountResult Apply(Order order)
        {
            return new DiscountResult { DiscountValue = (order.CatalogPrice * 10 / 100), SortOrder = this.SortOrder };
        }
    }


}
