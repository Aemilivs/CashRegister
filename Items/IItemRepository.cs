namespace CashRegister.Items
{
    public interface IItemRepository
    {
        public ItemBase CreateItem(ItemBase item);
        public ItemBase ReadItem(string sku);
        public bool UpdateItem(ItemBase item);
        public bool DeleteItem(ItemBase item);
    }
}