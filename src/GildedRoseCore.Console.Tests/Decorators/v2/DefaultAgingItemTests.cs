using ConsoleApplication;
using GildedRoseCore.Console.Decorators.v2;
using Xunit;

namespace GildedRoseCore.Console.Tests.Decorators.v2
{
    public class DefaultAgingItemTests
    {
        private readonly AbstractStockItem _testItem;
        public DefaultAgingItemTests()
        {
            _testItem = new DefaultAgingItem(new Item()
            {
                Name = "Test Item",
                Quality = 40,
                SellIn = 10


            });
        }

        [Fact]
        public void Update_Should_Decrement_SellIn_By_1()
        {
            _testItem.UpdateItem();
            Assert.Equal(9, _testItem.SellIn);
        }

        [Fact]
        public void SellIn_Can_Go_Negative()
        {
            _testItem.SellIn = 0;
            _testItem.UpdateItem();
            Assert.Equal(-1, _testItem.SellIn);
        }


    }
}
