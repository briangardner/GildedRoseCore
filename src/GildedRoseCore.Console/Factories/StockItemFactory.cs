using System;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console.Factories
{
    public class StockItemFactory : IStockItemFactory
    {
        public StockItem GetStockItem(Item item)
        {
            if (item.Name.Contains(ItemNames.Sulfuras))
            {
                return new ImmutableItem(item);
            }

            if (item.Name.Contains(ItemNames.AgedBrie))
            {
                return new AgedBrie(new AgingItem(item));
            }
            return new PerishableItem(new AgingItem(item));
        }
    }
}