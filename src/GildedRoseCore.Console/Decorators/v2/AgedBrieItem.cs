using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators.v2
{
    class AgedBrieItem : AbstractStockItem
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        protected override void ChangeQuality()
        {
            base.ChangeQuality();
            this.Quality++;
            if (this.Quality > 50)
            {
                this.Quality = 50;
            }
        }
    }
}
