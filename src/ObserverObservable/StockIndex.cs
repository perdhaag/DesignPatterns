namespace ObserverObservable;


public class StockIndex : IStockListener
{
    public string Name { get; set; }
    
    public double Index { get; set; }

    private List<Stock> Stocks { get; set; }
    public StockIndex(string name, double index, List<Stock> stocks)
    {
        Name = name;
        Index = index;
        Stocks = stocks;
    }

    public void AddStock(Stock stock)
    {
        Stocks.Add(stock);
    }
    
    public void RemoveStock(Stock stock)
    {
        Stocks.Remove(stock);
    }
    
    public void StockPriceChanged(Stock stock, double oldValue, double newValue)
    {
        if (stock.Price != newValue)
        {
            Console.WriteLine($"{stock.Ticker} has changed price from {oldValue} to new {newValue}");
            stock.Price = newValue;
        }
    }
}