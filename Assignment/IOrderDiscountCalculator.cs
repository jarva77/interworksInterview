

using ERP.Domain;

namespace ERP
{
    public interface IOrderDiscountCalculator
    {
        IEnumerable<DiscountResult>? Calculate(Order order);
    }
}