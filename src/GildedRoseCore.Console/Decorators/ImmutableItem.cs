using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal class ImmutableItem : StockItem
    {
        public ImmutableItem(Item item) : base(item)
        {
        }

    }
}
