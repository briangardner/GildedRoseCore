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


        protected override void Deteriorate()
        {
            if (SellIn < 0)
            {
                Item.Quality = 0;
                return;
            }

            Item.Quality += 1;
            if (SellIn < 11)
            {
                Item.Quality += 1;
            }

            if (SellIn < 6)
            {
                Item.Quality += 1;
            }
        }
    }
}
