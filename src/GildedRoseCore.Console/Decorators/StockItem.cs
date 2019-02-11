using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    public abstract class StockItem
    {
        protected readonly Item Item;
        private readonly StockItem _stockItem;
        protected StockItem(Item item)
        {
            Item = item;
        }

        protected StockItem(StockItem stockItem)
        {
            Item = stockItem.Item;
            _stockItem = stockItem;
        }

        public virtual void UpdateItem()
        {
            _stockItem?.UpdateItem();
            Deteriorate();
            Age();
        }

        public bool PastSellInDate => SellIn < 0;
        public int SellIn => Item.SellIn;
        public int Quality => Item.Quality;
        public string Name => Item.Name;

        protected abstract void Age();

        protected abstract void Deteriorate();

    }
}
