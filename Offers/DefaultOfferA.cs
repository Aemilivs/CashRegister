using CashRegister.Orders;

namespace CashRegister.Offers
{
    public class DefaultOfferA : OfferBase
    {
        public DefaultOfferA()
        {
            Discount = 20;
        }

        public override bool IsAppliable(OrderBase order)
        {
            if(order.Item.SKU == "A" && order.Count == 3)
                return true;

            return false;
        }
    }
}