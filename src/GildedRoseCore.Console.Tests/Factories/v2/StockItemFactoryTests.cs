using System;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators.v2;
using GildedRoseCore.Console.Factories.v2;
using Xunit;

namespace GildedRoseCore.Console.Tests.Factories
{
    public class StockItemFactoryTests
    {
        private readonly IStockItemFactory _factory;

        public StockItemFactoryTests()
        {
            _factory = new StockItemFactory();
        }

        [Fact]
        public void Item_With_No_Name_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentNullException>(() => _factory.GetStockItem(new Item()));
        }

        [Fact]
        public void Normal_Item_Should_Be_Perishable()
        {
            var stockItem = _factory.GetStockItem(new Item()
            {
                Name = "Random Name",
                Quality = 123,
                SellIn = 123
            });
            Assert.IsType<PerishableItem>(stockItem);
        }

        [Fact]
        public void Sulfuras_Should_Be_Immutable()
        {
            var stockItem = _factory.GetStockItem(new Item()
            {
                Name = ItemNames.Sulfuras,
                Quality = 20,
                SellIn = 10
            });
            Assert.IsType<ImmutableItem>(stockItem);
        }

        [Fact]
        public void AgedBrie_Should_Be_AgedBrie_Type()
        {
            var stockItem = _factory.GetStockItem(new Item()
            {
                Name = ItemNames.AgedBrie,
                Quality = 30,
                SellIn = 10
            });
            Assert.IsType<AgedBrieItem>(stockItem);
        }

        [Fact]
        public void Backstage_Tickets_Should_Be_BackstagePassItem_Type()
        {
            var stockItem = _factory.GetStockItem(new Item()
            {
                Name = ItemNames.BackstagePass,
                Quality = 20,
                SellIn = 10
            });
            Assert.IsType<BackstagePassItem>(stockItem);
        }
    }
}
