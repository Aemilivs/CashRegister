using CashRegister.Items;

namespace CashRegister.Orders
{
    public class DefaultOrder : OrderBase
    {
        public DefaultOrder(ItemBase item, int count)
        {
            Item = item;
            Count = count;
        }
    }
}