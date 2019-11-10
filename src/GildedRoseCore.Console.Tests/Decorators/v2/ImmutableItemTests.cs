using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Decorators.v2;
using Xunit;
using ImmutableItem = GildedRoseCore.Console.Decorators.v2.ImmutableItem;

namespace GildedRoseCore.Console.Tests.Decorators.v2
{
    public class ImmutableItemTests
    {
        private readonly AbstractStockItem _testItem;
        public ImmutableItemTests()
        {
            _testItem = new ImmutableItem(new Item()
            {
                Name = ItemNames.Sulfuras,
                Quality = 40,
                SellIn = 10
            });
        }
        [Fact]
        public void v2_ImmutableItem_Does_Not_Age()
        {
            _testItem.UpdateItem();
            Assert.Equal(10, _testItem.SellIn);
        }

        [Fact]
        public void v2_ImmutableItem_Does_Not_Change_Quality()
        {
            _testItem.UpdateItem();
            Assert.Equal(40, _testItem.Quality);
        }
    }
}
