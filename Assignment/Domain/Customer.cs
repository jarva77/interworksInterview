namespace ERP.Domain
{
    public partial class Customer : BaseEntity<int>
    {
        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}