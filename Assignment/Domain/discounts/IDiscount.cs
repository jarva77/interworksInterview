
namespace ERP.Domain
{
    public interface IDiscount
    {
        string Name { get; }
        DiscountType Type { get; }
        DiscountResult Apply(Order order);
        int SortOrder { get; }
    }

}
