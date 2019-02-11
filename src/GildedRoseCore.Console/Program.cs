using System;
using System.Collections.Generic;
using GildedRoseCore.Console;
using GildedRoseCore.Console.Factories;

namespace ConsoleApplication
{
    public class Program
    {
        private IList<Item> _items;
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            var guildedRose = new GuildedRose(new StockItemFactory());
            var app = new Program()
            {
                _items = new List<Item>
                {
                    new Item {Name = ItemNames.DexterityVest, SellIn = 10, Quality = 20},
                    new Item {Name = ItemNames.AgedBrie, SellIn = 2, Quality = 0},
                    new Item {Name = ItemNames.ElixirOfMongoose, SellIn = 5, Quality = 7},
                    new Item {Name = ItemNames.Sulfuras, SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = ItemNames.BackstagePass,
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = ItemNames.ManaCake, SellIn = 3, Quality = 6}
                    }
            };
            guildedRose.AddToStock(app._items);
            guildedRose.UpdateInventory();
            Console.ReadKey();
        }
    }
}
