using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    public abstract class StockItem : Item
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
        public new int SellIn => Item.SellIn;
        public new int Quality => Item.Quality;
        public new string Name => Item.Name;

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
