using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Decorators.v2;

namespace GildedRoseCore.Console.Factories.v2
{
    internal interface IStockItemFactory
    {
        AbstractStockItem GetStockItem(Item item);
    }
}