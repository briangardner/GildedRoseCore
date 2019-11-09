using System;
using System.Collections.Generic;
using GildedRoseCore.Console;
using GildedRoseCore.Console.Factories;
using GildedRoseCore.Console.Supplier;

namespace ConsoleApplication
{
    public class Program
    {
        private IList<Item> _items;
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            var stockItemFactory = new StockItemFactory();
            var guildedRose = new GuildedRose(stockItemFactory);
            var supplier = new Supplier(stockItemFactory, guildedRose);
            guildedRose.Subscribe(supplier);

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
            char inputChar;

            do
            {

                
                guildedRose.PrintStock();
                Console.WriteLine("*******************************\n\n");
                guildedRose.UpdateInventory();
                Console.WriteLine("Go forward another day? (N/n to stop Program)");
                inputChar = Console.ReadKey().KeyChar;

            } while (inputChar != 'n' || inputChar != 'N');

        }
    }
}
