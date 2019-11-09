using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Factories;

namespace GildedRoseCore.Console.Supplier
{
    public class Supplier : IObserver<StockItem>
    {
        private readonly IStockItemFactory _stockItemFactory;
        private readonly IStore _store;

        public Supplier(IStockItemFactory stockItemFactory, IStore store)
        {
            _stockItemFactory = stockItemFactory;
            _store = store;
        }

        public void OnNext(StockItem item)
        {
            if (item.Quality < 0)
            {
                System.Console.WriteLine($"{item.Name} has gone bad.  Time to remove it from stock.");
                _store.RemoveFromStock(item);
            }

            if (item.PastSellInDate)
            {
                System.Console.WriteLine($"{item.Name} has gone past its expiration date.  It still has some value, but you should sell it soon.");
            }
        }
    }
}
