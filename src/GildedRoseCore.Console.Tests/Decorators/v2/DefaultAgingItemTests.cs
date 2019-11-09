using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Decorators.v2;

namespace GildedRoseCore.Console.Tests.Decorators.v2
{
    public class DefaultAgingItemTests
    {
        private AbstractStockItem _testItem;
        public DefaultAgingItemTests()
        {
            _testItem = new DefaultAgingItem(new Item()
            {
                Name = "Test Item",
                Quality = 40,
                SellIn = 10
            });
        }

        
    }
}
