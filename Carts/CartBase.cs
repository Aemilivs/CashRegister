using System.Collections.Generic;
using CashRegister.Orders;

namespace CashRegister.Carts
{
    public abstract class CartBase
    {
        protected ICollection<OrderBase> Orders { get; set; }

        public abstract bool AddOrder(OrderBase order);
        public abstract OrderBase[] ReadOrders();
        public abstract bool RemoveOrder(OrderBase order);
    }
}