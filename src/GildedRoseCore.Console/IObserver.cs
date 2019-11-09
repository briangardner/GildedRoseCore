using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console
{
    public interface IObserver<in T> where T : StockItem
    {
        void OnNext(T item);
    }
}