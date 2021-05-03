namespace CashRegister.Items
{
    public abstract class ItemBase
    {
        public string SKU { get; set; }
        public decimal UnitPrice { get; set; }
    }
}