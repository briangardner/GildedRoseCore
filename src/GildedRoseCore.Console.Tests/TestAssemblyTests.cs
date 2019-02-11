using System;
using System.Collections.Generic;
using ConsoleApplication;
using GildedRoseCore.Console;
using GildedRoseCore.Console.Factories;
using Xunit;

namespace Tests
{
    public class TestAssemblyTests
    {
        private readonly GuildedRose _guildedRose;
        public TestAssemblyTests()
        {
            _guildedRose = new GuildedRose(new StockItemFactory());
        }
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
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
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
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(42, agedBrie.Quality);
        }

        [Fact]
        public void AgedBrie_Should_Quality_Should_Not_Exceed_50()
        {
            var agedBrie = new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 50,
                SellIn = 0
            };
            var items = new List<Item>
            {
                agedBrie
            };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(50, agedBrie.Quality);
        }

        [Fact]
        public void AgedBrie_SellIn_Go_Negative()
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
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(-1, agedBrie.SellIn);
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
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(9, agedBrie.SellIn);
        }

        [Fact]
        public void Sulfuras_Quality_Should_Not_Change()
        {
            var sulfuras = new Item()
            {
                Name = ItemNames.Sulfuras,
                Quality = 80,
                SellIn = 0
            };
            var items = new List<Item>()
            {
                sulfuras
            };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(80, sulfuras.Quality);
        }

        [Fact]
        public void Sulfuras_SellIn_Should_Not_Change()
        {
            var sulfuras = new Item()
            {
                Name = ItemNames.Sulfuras,
                Quality = 80,
                SellIn = 0
            };
            var items = new List<Item>()
            {
                sulfuras
            };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(0, sulfuras.SellIn);
        }

        [Fact]
        public void Backstage_Pass_Quality_Should_Increase_In_By_1_When_SellIn_Greater_Than_10()
        {
            var pass = new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 10,
                SellIn = 11
            };
            var items = new List<Item> {pass};
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(11, pass.Quality);
        }

        [Fact]
        public void Backstage_Pass_Quality_Should_Increase_In_By_2_When_SellIn_Is_10_Or_Less()
        {
            var pass = new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 10,
                SellIn = 10
            };
            var items = new List<Item> { pass };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(12, pass.Quality);
        }

        [Fact]
        public void Backstage_Pass_Quality_Should_Increase_In_By_3_When_SellIn_Is_5_Or_Less()
        {
            var pass = new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 10,
                SellIn = 5
            };
            var items = new List<Item> { pass };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(13, pass.Quality);
        }

        [Fact]
        public void Backstage_Pass_Quality_Should_Be_0_After_Concert()
        {
            var pass = new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 10,
                SellIn = -1
            };
            var items = new List<Item> { pass };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(0, pass.Quality);
        }

        [Fact]
        public void Other_Items_Should_Decrease_In_Quality_By_1_While_Sell_In_Greater_Than_0()
        {
            var vest = new Item
            {
                Name = ItemNames.DexterityVest,
                Quality = 25,
                SellIn = 10
            };
            var items = new List<Item> {vest};
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(24, vest.Quality);
        }

        [Fact]
        public void Other_Items_Should_Decrease_In_Quality_By_2_After_Sell_Date_Passed()
        {
            var vest = new Item
            {
                Name = ItemNames.DexterityVest,
                Quality = 25,
                SellIn = 0
            };
            var items = new List<Item> { vest };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(23, vest.Quality);
        }

        [Fact]
        public void Item_Quality_Should_Not_Go_Negative()
        {
            var vest = new Item
            {
                Name = ItemNames.DexterityVest,
                Quality = 0,
                SellIn = 0
            };
            var items = new List<Item> { vest };
            _guildedRose.AddToStock(items);
            _guildedRose.UpdateInventory();
            Assert.Equal(0, vest.Quality);
        }
    }
}
