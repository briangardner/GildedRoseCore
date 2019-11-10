using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Decorators.v2;
using GildedRoseCore.Console.Factories.v2;

namespace GildedRoseCore.Console
{
    class GuildedRose
    {
        private readonly IStockItemFactory _stockItemFactory;
        private IList<AbstractStockItem> _stock;
        // Dependency Inversion Principle going on here
        public GuildedRose(IStockItemFactory stockItemFactory)
        {
            _stockItemFactory = stockItemFactory;
            _stock = new List<AbstractStockItem>();
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

        public void RemoveFromStock(AbstractStockItem item)
        {
            _stock.Remove(item);
        }

        public IList<AbstractStockItem> GetStock()
        {
            return _stock;
        }

        public void PrintStock()
        {
            foreach (var item in _stock)
            {
                System.Console.WriteLine($"{item.Name,20} \t Quality:{item.Quality,4} \t SellIn:{item.SellIn,4}");
            }
        }

        public void ClearStock()
        {
            _stock = new List<AbstractStockItem>();
        }

        public void UpdateInventory()
        {
            //Liskov Substitution Principle going on here
            foreach (var item in _stock)
            {
                item.UpdateItem();
            }
        }
    }
}
