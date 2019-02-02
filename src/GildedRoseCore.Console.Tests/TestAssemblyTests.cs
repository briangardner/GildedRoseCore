using System;
using System.Collections.Generic;
using ConsoleApplication;
using GildedRoseCore.Console;
using Xunit;

namespace Tests
{
    public class TestAssemblyTests
    {
        
        [Fact]
        public void TestTheTruth() 
        {
            Assert.True(true);
        }

        [Fact]
        public void AgedBrie_Should_Increase_In_Quality_While_SellIn_Greater_Than_0()
        {
            var agedBrie = new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 40,
                SellIn = 10
            };
            var items = new List<Item>
            {
                agedBrie  
            };
            Program.UpdateQuality(items);
            Assert.Equal(41, agedBrie.Quality);
        }

        [Fact]
        public void AgedBrie_Should_Increase_In_Quality_Faster_When_Past_Sell_Date()
        {
            var agedBrie = new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 40,
                SellIn = 0
            };
            var items = new List<Item>
            {
                agedBrie
            };
            Program.UpdateQuality(items);
            Assert.Equal(42, agedBrie.Quality);
        }

        [Fact]
        public void AgedBrie_Should_Should_Decrease_SellIn()
        {
            var agedBrie = new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 40,
                SellIn = 10
            };
            var items = new List<Item>
            {
                agedBrie
            };
            Program.UpdateQuality(items);
            Assert.Equal(9, agedBrie.SellIn);
        }

    }
}
