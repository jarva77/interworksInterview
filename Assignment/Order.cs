using DiscountSubSystem;

namespace ERP
{
    public partial class Order
    {
        public Order(Customer customer) => Customer = customer;
        public Customer Customer { get; set; }
        public decimal CatalogPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public IEnumerable<IDiscount>? ApplicableDiscounts { get;set; }
    }
}
