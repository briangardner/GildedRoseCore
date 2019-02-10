using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal class AgedBrie : StockItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }

        public AgedBrie(StockItem stockItem) : base(stockItem)
        {
        }

        protected override void Age()
        {
            return;
        }

        protected override void Deteriorate()
        {
            if (Item.Quality < 50)
            {
                Item.Quality = Quality + 1;
            }
        }
    }
}
