using CashRegister.Items;

namespace CashRegister.Orders
{
    public abstract class OrderBase
    {
        public ItemBase Item { get; set; }
        public int Count { get; set; }
    }
}