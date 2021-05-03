using CashRegister.Items;
using CashRegister.Orders;

namespace CashRegister.Offers
{
    public abstract class OfferBase
    {
        public decimal Discount { get; set; }

        public abstract bool IsAppliable(OrderBase order);
    }
}