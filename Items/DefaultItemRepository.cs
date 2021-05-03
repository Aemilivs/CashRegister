using System.Collections.Generic;

namespace CashRegister.Items
{
    public class DefaultItemRepository : IItemRepository
    {
        private readonly List<ItemBase> _items = new List<ItemBase>();
        
        public ItemBase CreateItem(ItemBase item)
        {
            _items.Add(item);

            return item;
        }

        public bool DeleteItem(ItemBase item)
        {   
            return _items.Remove(item);
        }

        public ItemBase ReadItem(string sku)
        {
            return _items.Find(it => it.SKU == sku);
        }

        public bool UpdateItem(ItemBase item)
        {
            var target = _items.Find(it => it.SKU == item.SKU);
            target = item;
            return true;
        }
    }
}