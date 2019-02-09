using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators
{
    public class AgingItemTests
    {
        [Fact]
        public void Update_Should_Decrement_SellIn_By_1()
        {
            var cheese = new AgingItem(new Item()
            {
                Name = ItemNames.DexterityVest,
                Quality = 20,
                SellIn = 10
            });
            cheese.UpdateItem();
            Assert.Equal(9, cheese.SellIn);
        }

        [Fact]
        public void SellIn_Can_Go_Negative()
        {
            var cheese = new AgingItem(new Item()
            {
                Name = ItemNames.DexterityVest,
                Quality = 20,
                SellIn = 0
            });
            cheese.UpdateItem();
            Assert.Equal(-1, cheese.SellIn);
        }
    }
}
