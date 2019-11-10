using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators.v2
{
    class DefaultAgingItem : AbstractStockItem
    {
        public DefaultAgingItem(Item item) : base(item)
        {
        }

        public DefaultAgingItem(AbstractStockItem item) : base(item)
        {
            
        }

        protected override void Age()
        {
            base.Age();
            this.SellIn--;
        }
    }
}
