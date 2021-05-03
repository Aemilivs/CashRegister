using CashRegister.Carts;
using CashRegister.Orders;

namespace CashRegister.Customers
{
    public class DefaultCustomer : CustomerBase
    {
        public DefaultCustomer(CartBase cart)
        {
            Cart = cart;
        }

        public override void AddItemToCart(OrderBase order)
        {
            Cart.AddOrder(order);
        }

        public override OrderBase[] GetOrders()
        {
            return Cart.ReadOrders();
        }

        public override void RemoveItemsFromCart(OrderBase order)
        {
            Cart.RemoveOrder(order);
        }
    }
}