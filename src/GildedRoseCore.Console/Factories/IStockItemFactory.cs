using ConsoleApplication;
using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console.Factories
{
    public interface IStockItemFactory
    {
        StockItem GetStockItem(Item item);
    }
}