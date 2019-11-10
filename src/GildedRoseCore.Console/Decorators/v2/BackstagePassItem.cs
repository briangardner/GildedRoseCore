using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators.v2
{
    class BackstagePassItem : AbstractStockItem
    {
        public BackstagePassItem(Item item) : base(item)
        {
        }

        public BackstagePassItem(AbstractStockItem item) : base(item)
        {
        }

        protected override void ChangeQuality()
        {
            base.ChangeQuality();
            if (SellIn < 0)
            {
                Quality = 0;
                return;
            }

            Quality += 1;
            if (SellIn < 11)
            {
                Quality += 1;
            }

            if (SellIn < 6)
            {
                Quality += 1;
            }

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}
