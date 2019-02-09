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
        public void Update_Should_Decrement_SellIn_By_1()
        {
            var cheese = new AgedBrie(new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 20,
                SellIn = 10
            });
            cheese.UpdateItem();
            Assert.Equal(9, cheese.SellIn);
        }

        [Fact]
        public void SellIn_Can_Go_Negative()
        {
            var cheese = new AgedBrie(new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 20,
                SellIn = 0
            });
            cheese.UpdateItem();
            Assert.Equal(-1, cheese.SellIn);
        }

        [Fact]
        public void UpdateItem_Should_Increase_Quality()
        {
            var cheese = new AgedBrie(new Item()
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
            var cheese = new AgedBrie(new Item()
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
