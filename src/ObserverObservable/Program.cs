// See https://aka.ms/new-console-template for more information

using ObserverObservable;

var stock1 = new Stock("NOR", 10);
var stock2 = new Stock("SWE", 20);

var index = new StockIndex("TestIndex", 1, new List<Stock>{stock1,stock2});

stock1.AddStockListener(index);
stock2.AddStockListener(index);

stock1.SetPrice(200);
stock2.SetPrice(1000);