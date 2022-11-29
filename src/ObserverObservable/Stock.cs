namespace ObserverObservable;

public class Stock
{
    public string Ticker { get; set; }
    
    public double Price { get; set; }

    public List<IStockListener> StockListeners = new List<IStockListener>();
    public Stock(string ticker, double price)
    {
        Ticker = ticker;
        Price = price;
    }

    public void SetPrice(double newPrice)
    {
        if (newPrice < 0 || newPrice == 0)
        {
            throw new ArgumentException();
        }
        foreach (var observer in StockListeners)
        {
            observer.StockPriceChanged(this, Price, newPrice);
        }
        Price = newPrice;
    }

    public void AddStockListener(IStockListener listener)
    {
        if (!StockListeners.Contains(listener))
        {
            StockListeners.Add(listener);
        }
    }
    
    public void RemoveStockListener(IStockListener listener)
    {
        if (StockListeners.Contains(listener))
        {
            StockListeners.Remove(listener);
        }
    }
}

