using GildedRoseCore.Console.Decorators;

namespace GildedRoseCore.Console
{
    public interface IObservable<out T> where T : StockItem
    {
        void Subscribe(IObserver<T> observer);
    }
}