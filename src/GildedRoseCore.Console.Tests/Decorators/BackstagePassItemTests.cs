using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators
{
    [Collection("Backstage Pass Tests")]
    public class BackstagePassItemTests
    {
        [Fact]
        public void Quality_Should_Increase_By_1_When_SellIn_Greater_Than_10()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = 11
            });
            item.UpdateItem();
            Assert.Equal(21, item.Quality);
        }

        [Fact]
        public void Quality_Should_Increase_By_2_When_SellIn_10()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = 10
            });
            item.UpdateItem();
            Assert.Equal(22, item.Quality);
        }

        [Fact]
        public void Quality_Should_Increase_By_2_When_SellIn_Less_Than_10_Greater_Than_5()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = 6
            });
            item.UpdateItem();
            Assert.Equal(22, item.Quality);
        }

        [Fact]
        public void Quality_Should_Increase_By_3_When_SellIn_5()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = 5
            });
            item.UpdateItem();
            Assert.Equal(23, item.Quality);
        }

        [Fact]
        public void Quality_Should_Increase_By_3_When_SellIn_Less_Than_5_Not_Negative()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = 0
            });
            item.UpdateItem();
            Assert.Equal(23, item.Quality);
        }

        [Fact]
        public void Quality_Should_Be_0_When_SellIn_Negative()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = -1
            });
            item.UpdateItem();
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void Quality_Should_Not_Go_Negative_When_Already_At_0()
        {
            var item = new BackstagePassItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 0,
                SellIn = -1
            });
            item.UpdateItem();
            Assert.Equal(0, item.Quality);
        }
    }
}
