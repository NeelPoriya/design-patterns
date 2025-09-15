using ConsoleApp.Problems.VendingMachine.Models;

namespace ConsoleApp.Problems.VendingMachine
{
    public class Inventory
    {
        private Dictionary<string, Item> itemMap = [];
        private Dictionary<string, int> stockMap = [];
        public void AddItem(string id, Item item, int quantity)
        {
            if (itemMap.TryGetValue(id, out var it))
            {
                throw new Exception($"Item already exist at key : {id}");
            }

            if (stockMap.TryGetValue(id, out var _))
            {
                throw new Exception($"Stock already present at key : {id}");
            }

            itemMap.TryAdd(id, item);
            stockMap.TryAdd(id, quantity);
        }

        public void ReduceStock(string itemId)
        {
            if (!stockMap.TryGetValue(itemId, out int stock))
            {
                throw new Exception($"Item {itemId} not found");
            }

            if (stock == 0)
            {
                throw new Exception($"Stock for item {itemId} is empty");
            }

            stockMap[itemId]--;
        }

        public bool IsAvailable(string itemId)
        {
            if (stockMap.TryGetValue(itemId, out int stock))
            {
                return stock > 0;
            }
            return false;
        }

        public Item? GetItem(string itemId)
        {
            itemMap.TryGetValue(itemId, out Item? item);
            return item;
        }
    }
}