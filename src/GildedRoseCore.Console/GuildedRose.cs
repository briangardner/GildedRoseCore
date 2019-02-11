using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Factories;

namespace GildedRoseCore.Console
{
    class GuildedRose
    {
        private readonly IStockItemFactory _stockItemFactory;
        private IList<StockItem> _stock;
        public GuildedRose(IStockItemFactory stockItemFactory)
        {
            _stockItemFactory = stockItemFactory;
            _stock = new List<StockItem>();
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

        public IList<StockItem> GetStock()
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
            _stock = new List<StockItem>();
        }

        public void UpdateInventory()
        {
            foreach (var item in _stock)
            {
                item.UpdateItem();
            }
        }
    }
}
