using EconomyTraderPrototype.MarketAgents;

namespace EconomyTraderPrototype.Markets
{
    public class Market
    {
        public string Name { get; private set; }
        public IDictionary<string, MarketGood> Goods { get; private set; }
        public IDictionary<string, BaseMarketAgent> MarketAgents { get; private set; }

        public Market(string marketName, IDictionary<string, MarketGood> goods, IDictionary<string, BaseMarketAgent> marketAgents)
        {
            Name = marketName;
            Goods = goods;
            MarketAgents = marketAgents;
        }

        public void TickMarket() 
        {
            foreach(var good in Goods.Values)
            {
                good.TickPrice();
            }
        }

        public void DebugLog()
        {
            Console.WriteLine("----------");

            Console.WriteLine($"Market: {Name}");
            foreach(var good in Goods.Values)
                good.DebugLog();

            Console.WriteLine("----------");
        }
    }
}
