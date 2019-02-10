using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal class PerishableItem : StockItem
    {
        public PerishableItem(Item item) : base(item)
        {
        }

        public PerishableItem(StockItem stockItem):base(stockItem)
        {
        }

        protected override void Age()
        {
            return;
        }

        protected override void Deteriorate()
        {
            //Item quality cannot be negative.  So if Quality is 0, don't bother checking anything else.
            if (Item.Quality == 0)
            {
                return;
            }

            //Item quality degrades 2x faster once SellIn date has passed.
            if (PastSellInDate)
            {
                Item.Quality = Quality - 2;
            }
            else
            {
                Item.Quality = Quality - 1;
            }

            //Item quality cannot be negative
            if (Item.Quality < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
