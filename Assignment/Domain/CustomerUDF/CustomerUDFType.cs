

namespace ERP.Domain
{
    public class CustomerUDFType : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public UDFType UDFType { get; set; }
        public LookUp? LookUp { get; set; }
    }
}
