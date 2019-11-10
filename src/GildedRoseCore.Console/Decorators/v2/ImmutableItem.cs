using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators.v2
{
    internal class ImmutableItem : AbstractStockItem
    {
        public ImmutableItem(Item item) : base(item)
        {
        }

        public ImmutableItem(AbstractStockItem item) : base(item)
        {
            
        }
    }
}
