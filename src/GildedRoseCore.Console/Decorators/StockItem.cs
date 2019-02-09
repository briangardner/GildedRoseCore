using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    public abstract class StockItem
    {
        private readonly Item _item;

        protected StockItem(Item item)
        {
            _item = item;
        }

        public virtual void UpdateItem()
        {
            Age();
            Deteriorate();
        }
        protected abstract void Age();
        protected abstract void Deteriorate();
    }
}
