using System.Collections.Generic;
using CashRegister.Offers;
using CashRegister.Orders;

namespace CashRegister.Checkouts
{
    public class DefaultCheckout : CheckoutBase
    {
        public DefaultCheckout()
        {
            Orders = new List<OrderBase>();
            Offers = new List<OfferBase>();
            Sum = 0;
        }
    }
}