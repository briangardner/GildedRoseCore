using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators
{
    [Collection("Perishable Item Tests")]
    public class PerishableItemTests
    {
        [Fact]
        public void Should_Decrease_Quality_By_1_If_Quality_Greater_Than_0_And_Not_Past_SellIn_Date()
        {
            var item = new PerishableItem(new Item()
            {
                Name = ItemNames.ElixirOfMongoose,
                Quality = 20,
                SellIn = 5
            });
            item.UpdateItem();
            Assert.Equal(19, item.Quality);
        }

        [Fact]
        public void Should_Decrease_Quality_By_1_If_Quality_Greater_Than_0_And_SellIn_0()
        {
            var item = new PerishableItem(new Item()
            {
                Name = ItemNames.ElixirOfMongoose,
                Quality = 20,
                SellIn = 0
            });
            item.UpdateItem();
            Assert.Equal(19, item.Quality);
        }

        [Fact]
        public void Should_Decrease_Quality_By_2_If_Quality_Greater_Than_1_And_Past_SellIn_Date()
        {
            var item = new PerishableItem(new Item()
            {
                Name = ItemNames.ElixirOfMongoose,
                Quality = 20,
                SellIn = -1
            });
            item.UpdateItem();
            Assert.Equal(18, item.Quality);
        }

        [Fact]
        public void Should_Not_Allow_Quality_To_Go_Negative()
        {
            var item = new PerishableItem(new Item()
            {
                Name = ItemNames.ElixirOfMongoose,
                Quality = 1,
                SellIn = -1
            });
            item.UpdateItem();
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void Should_Keep_Quality_At_0()
        {
            var item = new PerishableItem(new Item()
            {
                Name = ItemNames.ElixirOfMongoose,
                Quality = 0,
                SellIn = 2
            });
            item.UpdateItem();
            Assert.Equal(0, item.Quality);
        }
    }
}
