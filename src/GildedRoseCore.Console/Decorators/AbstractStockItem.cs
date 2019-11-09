using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;

namespace GildedRoseCore.Console.Decorators
{
    internal abstract class AbstractStockItem : Item
    {
        private readonly Item _item;

        protected AbstractStockItem(Item item)
        {
            _item = item;
            this.SellIn = item.SellIn;
            this.Name = item.Name;
            this.Quality = item.Quality;
        }

        protected virtual void Age()
        {
            return; // Default No Operation
        }

        protected virtual void ChangeQuality()
        {
            return; // Default No Operation
        }

        public virtual void UpdateItem()
        {
            Age();
            ChangeQuality();
        }

    }
}
