
namespace ERP.Domain
{
    public partial class Order : BaseEntity<int>
    {
        public Order(Customer customer) => Customer = customer;
        public Customer Customer { get; set; }
        public decimal CatalogPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public IEnumerable<IDiscount>? ApplicableDiscounts { get;set; }
    }
}
