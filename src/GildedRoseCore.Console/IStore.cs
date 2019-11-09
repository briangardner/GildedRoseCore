using System.Collections.Generic;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console
{
    public interface IStore
    {
        void AddToStock(IList<Item> items);
        void AddToStock(Item item);
        void RemoveFromStock(StockItem item);
        ICollection<StockItem> GetStock();
        void PrintStock();
        void ClearStock();
        void UpdateInventory();
    }
}