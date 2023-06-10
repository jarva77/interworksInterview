namespace DiscountSubSystem
{
    public class DiscountResult
    {
        public DiscountResult(string name, decimal discountValue, int sortOrder)
        {
            this.Name = name;
            this.DiscountValue = discountValue;
            this.SortOrder = sortOrder;
        }
        public string Name { get; internal set; }
        public decimal DiscountValue { get; set; }
        public int SortOrder { get; set; }

        public override string ToString()
        {
            return $"{this.Name} : -{this.DiscountValue}";
        }
    }

}
