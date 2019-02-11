using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal class AgedBrieItem : StockItem
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        public AgedBrieItem(StockItem stockItem) : base(stockItem)
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
