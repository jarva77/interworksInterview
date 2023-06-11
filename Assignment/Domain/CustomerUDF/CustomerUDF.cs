

namespace ERP.Domain
{
    public class CustomerUDF : BaseEntity<int>
    {
        public Customer Customer { get; set; }
        public CustomerUDFType UDFType { get; set; }
        public string? UdfValue { get;set; }
    }
}