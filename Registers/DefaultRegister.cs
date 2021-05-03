using System.Collections.Generic;
using System.Linq;
using CashRegister.Bags;
using CashRegister.Checkouts;
using CashRegister.Customers;
using CashRegister.Offers;

namespace CashRegister.Registers
{
    public class DefaultRegister : RegisterBase
    {
        public DefaultRegister(ICollection<OfferBase> offers, BagBase bagType)
        {
            Offers = offers;
            BagType = bagType;
        }

        public override CheckoutBase Checkout(CustomerBase customer)
        {
            var orders = customer.GetOrders();
            var sum = orders.Sum(it => it.Item.UnitPrice * it.Count);

            var discount = 
                orders.Sum(
                    order => 
                        Offers
                            .Where(it => it.IsAppliable(order))
                            .Sum(it => it.Discount)
                    );

            var fee = 
                orders.Sum(it => it.Count) % 
                this.BagType.Capacity * 
                this.BagType.Price;

            return 
                new DefaultCheckout
                {
                    Offers = this.Offers,
                    Orders = orders,
                    Discount = discount,
                    Fee = fee,
                    Sum = sum
                };
        }
    }
}