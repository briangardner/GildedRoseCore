using ConsoleApplication;
using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console.Factories.v2
{
    internal interface IStockItemFactory
    {
        AbstractStockItem GetStockItem(Item item);
    }
}