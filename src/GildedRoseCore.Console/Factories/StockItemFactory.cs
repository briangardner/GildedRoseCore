using System;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console.Factories
{
    public class StockItemFactory : IStockItemFactory
    {
        public StockItem GetStockItem(Item item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentNullException(nameof(item.Name), "Item Name cannot be null");
            }
            if (item.Name.Contains(ItemNames.Sulfuras))
            {
                return new ImmutableItem(item);
            }

            if (item.Name.Contains(ItemNames.AgedBrie))
            {
                return new AgedBrieItem(new AgingItem(item));
            }

            if (item.Name.Contains("Backstage"))
            {
                return new AgingItem(new BackstagePassItem(item));
            }


            return new PerishableItem(new AgingItem(item));
        }
    }
}