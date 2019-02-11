using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal class BackstagePassItem : StockItem
    {
        public BackstagePassItem(Item item) : base(item)
        {
        }

        public BackstagePassItem(StockItem stockItem) : base(stockItem)
        {
        }

        protected override void Age()
        {
        }

        protected override void Deteriorate()
        {
            if (SellIn < 0)
            {
                Item.Quality = 0;
                return;
            }
            if (SellIn > 10)
            {
                Item.Quality += 1;
                return;
            }
            if (SellIn > 5)
            {
                Item.Quality += 2;
            }
            else
            {
                Item.Quality += 3;
            }
        }
    }
}
