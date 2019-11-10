using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators.v2;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators.v2
{
    public class PerishableItemTests
    {
        private readonly AbstractStockItem _testItem;

        public PerishableItemTests()
        {
            _testItem = new PerishableItem(new Item()
            {
                Name = "Some test item",
                Quality = 10,
                SellIn = 10
            });
        }

        [Fact]
        public void Should_Decriment_Count_By_1()
        {
            _testItem.UpdateItem();
            Assert.Equal(9, _testItem.Quality);
        }


        [Fact]
        public void Should_Not_Let_Quality_Go_Negative()
        {
            _testItem.Quality = 0;
            _testItem.UpdateItem();
            Assert.Equal(0, _testItem.Quality);
        }

        [Fact]
        public void Should_Degrade_By_2_when_Sellby_Is_Negative()
        {
            _testItem.SellIn = -1;
            _testItem.UpdateItem();
            Assert.Equal(8, _testItem.Quality);
        }
    }
}
