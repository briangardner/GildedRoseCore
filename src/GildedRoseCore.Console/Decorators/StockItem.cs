using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    public abstract class StockItem
    {
        protected readonly Item Item;

        protected StockItem(Item item)
        {
            Item = item;
        }

        public virtual void UpdateItem()
        {
            Age();
            Deteriorate();
        }

        public int SellIn => Item.SellIn;
        public int Quality => Item.Quality;
        protected abstract void Age();
        protected abstract void Deteriorate();
    }
}
