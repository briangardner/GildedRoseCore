using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators
{
    [Collection("Aged Brie")]
    public class AgedBrieTests
    {
        

        [Fact]
        public void UpdateItem_Should_Increase_Quality()
        {
            var cheese = new AgedBrieItem(new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 20,
                SellIn = 10
            });
            cheese.UpdateItem();
            Assert.Equal(21, cheese.Quality);
        }

        [Fact]
        public void UpdateItem_Should_Not_Let_Quality_Go_Over_50()
        {
            var cheese = new AgedBrieItem(new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 50,
                SellIn = 10
            });
            cheese.UpdateItem();
            Assert.Equal(50, cheese.Quality);
        }
    }
}
