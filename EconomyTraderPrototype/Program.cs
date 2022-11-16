// See https://aka.ms/new-console-template for more information
using EconomyTraderPrototype;
using EconomyTraderPrototype.Market;

Console.WriteLine("Market Simulator");

string? input = "";

Randomizer.SetSeed(123);

var goods = new List<MarketGood>()
{
    new("Apple", 10),
    //new("Banana", 20),
    //new("Meat", 100),
};

goods[0].AddSupply(20);
goods[0].AddDemand(10);

//goods[1].AddSupply(50);
//goods[1].AddDemand(100);

//goods[2].AddSupply(100);
//goods[2].AddDemand(100);


Market market = new Market("Market 1", goods);

do
{
    input = Console.ReadLine();

    switch (input)
    {
        case "t": 
            market.TickMarket();
            market.DebugLog(); 
            break;
        case "d":
            goods[0].AddDemand(5); break;
        case "s":
            goods[0].AddSupply(5); break;
        default: break;
    }

} while (input != "exit");
