namespace DiscountSubSystem
{
    public class Customer
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
