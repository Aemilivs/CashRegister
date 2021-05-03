using System.Collections.Generic;
using System.Linq;
using CashRegister.Orders;

namespace CashRegister.Carts
{
    public class DefaultCart : CartBase
    {
        public DefaultCart()
        {
            Orders = new List<OrderBase>();
        }

        public override bool AddOrder(OrderBase order)
        {
            Orders.Add(order);

            return true;
        }

        public override OrderBase[] ReadOrders()
        {
            return Orders.ToArray();
        }

        public override bool RemoveOrder(OrderBase order)
        {
            Orders.Remove(order);

            return true;
        }
    }
}