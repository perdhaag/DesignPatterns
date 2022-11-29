namespace ObserverObservable;

public interface IStockListener
{
    void StockPriceChanged(Stock stock, double oldValue, double newValue);
}