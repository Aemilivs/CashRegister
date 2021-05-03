using CashRegister.Orders;

namespace CashRegister.Offers
{
    public class DefaultOfferB : OfferBase
    {
        public DefaultOfferB()
        {
            Discount = 15;
        }

        public override bool IsAppliable(OrderBase order)
        {
            if(order.Item.SKU == "B" && order.Count == 2)
                return true;

            return false;
        }
    }
}