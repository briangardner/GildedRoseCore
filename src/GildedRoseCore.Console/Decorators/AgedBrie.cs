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

        protected override void Deteriorate()
        {
            base.Deteriorate();
            if (Item.Quality < 50)
            {
                Item.Quality = Quality + 1;
            }
        }
    }
}
