using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators.v2
{
    class PerishableItem : AbstractStockItem
    {
        public PerishableItem(Item item) : base(item)
        {
        }

        public PerishableItem(AbstractStockItem item) : base(item)
        {
            
        }

        protected override void ChangeQuality()
        {
            base.ChangeQuality();
            //Item quality cannot be negative.  So if Quality is 0, don't bother checking anything else.
            if (Quality == 0)
            {
                return;
            }

            //Item quality degrades 2x faster once SellIn date has passed.
            if (SellIn < 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality -= 1;
            }

            //Item quality cannot be negative
            if (Quality < 0)
            {
                Quality = 0;
            }
        }
    }
}
