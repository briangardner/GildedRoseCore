using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators.v2
{
    internal abstract class AbstractStockItem : Item
    {
        protected readonly Item Item = null;
        protected readonly AbstractStockItem StockItem = null;

        protected AbstractStockItem(Item item)
        {
            Item = item;
        }

        // This is needed to chain Decorators together.  base.Age() calls Age on AbstractStockItem, not the child decorator.
        protected AbstractStockItem(AbstractStockItem item)
        {

            StockItem = item;
            Item = item.Item;
        }

        /// <summary>
        /// This stops each layer keeping its own copy of SellIn.  Not needed if requirements were that we could change Item class.
        /// </summary>
        public new int SellIn
        {
            get => Item.SellIn;
            set => Item.SellIn = value;
        }

        /// <summary>
        /// This stops each layer keeping its own copy of Quality.  Not needed if requirements were that we could change Item class.
        /// </summary>
        public new int Quality
        {
            get => Item.Quality;
            set => Item.Quality = value;
        }

        protected virtual void Age()
        {
            StockItem?.Age(); // this will call nested decorators
        }

        protected virtual void ChangeQuality()
        {
            StockItem?.ChangeQuality(); // this will call nested decorators
        }

        public virtual void UpdateItem()
        {
            Age();
            ChangeQuality();
        }

    }
}
