using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal class AgingItem : StockItem
    {
        public AgingItem(Item item) : base(item)
        {
        }

        protected override void Age()
        {
            base.Age();
            Item.SellIn = SellIn - 1;
        }
    }
}
