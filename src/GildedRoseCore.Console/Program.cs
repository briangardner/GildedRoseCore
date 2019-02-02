using System;
using System.Collections.Generic;
using GildedRoseCore.Console;

namespace ConsoleApplication
{
    public class Program
    {
        private IList<Item> _items;
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

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
            app.UpdateQuality(app._items);

            Console.ReadKey();
        }

        public void UpdateQuality(IList<Item> items)
        {
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Name != ItemNames.AgedBrie && items[i].Name != ItemNames.BackstagePass)
                {
                    if (items[i].Quality > 0)
                    {
                        if (items[i].Name != ItemNames.Sulfuras)
                        {
                            items[i].Quality = items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (items[i].Quality < 50)
                    {
                        items[i].Quality = items[i].Quality + 1;

                        if (items[i].Name == ItemNames.BackstagePass)
                        {
                            if (items[i].SellIn < 11)
                            {
                                if (items[i].Quality < 50)
                                {
                                    items[i].Quality = items[i].Quality + 1;
                                }
                            }

                            if (items[i].SellIn < 6)
                            {
                                if (items[i].Quality < 50)
                                {
                                    items[i].Quality = items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (items[i].Name != ItemNames.Sulfuras)
                {
                    items[i].SellIn = items[i].SellIn - 1;
                }

                if (items[i].SellIn < 0)
                {
                    if (items[i].Name != ItemNames.AgedBrie)
                    {
                        if (items[i].Name != ItemNames.BackstagePass)
                        {
                            if (items[i].Quality > 0)
                            {
                                if (items[i].Name != ItemNames.Sulfuras)
                                {
                                    items[i].Quality = items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            items[i].Quality = items[i].Quality - items[i].Quality;
                        }
                    }
                    else
                    {
                        if (items[i].Quality < 50)
                        {
                            items[i].Quality = items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
