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
            Age();
            Deteriorate();
        }

        public bool PastSellInDate => SellIn < 0;
        public int SellIn => Item.SellIn;
        public int Quality => Item.Quality;

        protected virtual void Age()
        {
            return;
        }

        protected virtual void Deteriorate()
        {
            return;
        }
    }
}
