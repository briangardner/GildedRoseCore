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

        public AgingItem(StockItem stockItem): base(stockItem) { }
        

        protected override void Age()
        {
            Item.SellIn = SellIn - 1;
        }

        protected override void Deteriorate()
        {
            return;
        }
    }
}
