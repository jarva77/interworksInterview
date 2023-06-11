
namespace ERP.Domain
{
    public class CustomerUDF_Log : BaseEntity<int>
    {
        public Customer Customer { get; set; }
        public CustomerUDFType UDFType { get; set; }
        public string? UdfValue { get; set; }
        public string UserName { get; set; }
        public DateTime CrudDate { get; set; }
        public CrudAction CrudAction { get; set; }
    }
}