using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Factories;

namespace GildedRoseCore.Console
{
    class GuildedRose : IStore, IObservable<StockItem>
    {
        private readonly IStockItemFactory _stockItemFactory;
        private ICollection<StockItem> _stock;

        private ICollection<IObserver<StockItem>> _observers;

        // Dependency Inversion Principle going on here
        public GuildedRose(IStockItemFactory stockItemFactory)
        {
            _stockItemFactory = stockItemFactory;
            _stock = new List<StockItem>();
            _observers = new List<IObserver<StockItem>>();
        }

        public void AddToStock(IList<Item> items)
        {
            foreach (var item in items)
            {
                AddToStock(item);
            }
        }

        public void AddToStock(Item item)
        {
            try
            {
                _stock.Add(_stockItemFactory.GetStockItem(item));
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Can't add that to the stock. {0}", ex.ToString());
            }
        }

        public void RemoveFromStock(StockItem item)
        {
            _stock.Remove(item);
        }

        public ICollection<StockItem> GetStock()
        {
            return _stock;
        }

        public void PrintStock()
        {
            foreach (var item in _stock)
            {
                System.Console.WriteLine($"{item.Name,40} \t Quality:{item.Quality,4} \t SellIn:{item.SellIn,4}");
            }
        }

        public void ClearStock()
        {
            _stock = new List<StockItem>();
        }

        public void UpdateInventory()
        {
            //Liskov Substitution Principle going on here
            foreach (var item in _stock.ToList())
            {
                item.UpdateItem();
                foreach (var observer in _observers)
                {
                    observer.OnNext(item);
                }
            }
        }

        public void Subscribe(IObserver<StockItem> observer)
        {
            _observers.Add(observer);
        }
    }
}
