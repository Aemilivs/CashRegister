namespace CashRegister.Items
{
    public class DefaultItem : ItemBase
    {
        public DefaultItem(string sku, decimal unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
        }
    }
}