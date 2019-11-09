﻿using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using Xunit;
using AgedBrieItem = GildedRoseCore.Console.Decorators.v2.AgedBrieItem;

namespace GildedRoseCore.Console.Tests.Decorators.v2
{
    public class AgedBrieItemTests
    {
        private AbstractStockItem _testItem;
        public AgedBrieItemTests()
        {
            _testItem = new AgedBrieItem(new Item()
            {
                Name = "Aged Brie",
                Quality = 40,
                SellIn = 10
            });
        }

        [Theory]
        [InlineData(40, 41)]
        [InlineData(49, 50)]
        [InlineData(50, 50)]
        public void AgedBrie_Quality_Should_Increase_After_Update(int starting, int expected)
        {
            _testItem.Quality = starting;
            _testItem.UpdateItem();
            Assert.Equal(expected, _testItem.Quality);
        }
    }
}
