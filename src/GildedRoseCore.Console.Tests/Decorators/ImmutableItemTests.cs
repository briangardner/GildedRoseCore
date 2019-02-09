using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators
{
    [Collection("ImmutableItem Tests")]
    public class ImmutableItemTests
    {
        [Fact]
        public void UpdateItem_Should_Not_Change_SellIn()
        {
            var item = new ImmutableItem(new Item()
            {
                Name = ItemNames.Sulfuras,
                Quality = 40,
                SellIn = 10
            });
            item.UpdateItem();
            Assert.Equal(10, item.SellIn);
        }

        [Fact]
        public void UpdateItem_Should_Not_Change_Quality()
        {
            var item = new ImmutableItem(new Item()
            {
                Name = ItemNames.Sulfuras,
                Quality = 40,
                SellIn = 10
            });
            item.UpdateItem();
            Assert.Equal(40, item.Quality);
        }
    }
}
