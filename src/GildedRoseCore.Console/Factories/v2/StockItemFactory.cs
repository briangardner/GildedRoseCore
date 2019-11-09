﻿using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication;
using GildedRoseCore.Console.Decorators;
using GildedRoseCore.Console.Decorators.v2;
using ImmutableItem = GildedRoseCore.Console.Decorators.v2.ImmutableItem;

namespace GildedRoseCore.Console.Factories.v2
{
    class StockItemFactory : IStockItemFactory
    {
        public AbstractStockItem GetStockItem(Item item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentNullException(nameof(item.Name));
            }
            if (item.Name.Contains(ItemNames.Sulfuras))
            {
                return new ImmutableItem(item);
            }
            return new DefaultAgingItem(item);
        }
    }
}