using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    class AgedBrie : StockItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }

        protected override void Age()
        {
            Item.SellIn--;
        }

        protected override void Deteriorate()
        {
            if (Item.Quality < 50)
            {
                Item.Quality++;
            }
        }
    }
}
