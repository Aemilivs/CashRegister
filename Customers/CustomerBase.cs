using CashRegister.Carts;
using CashRegister.Orders;

namespace CashRegister.Customers
{
    public abstract class CustomerBase
    {
        public CartBase Cart { get; set; }

        public abstract void AddItemToCart(OrderBase order);

        public abstract void RemoveItemsFromCart(OrderBase order);

        public abstract OrderBase[] GetOrders();
    }
}