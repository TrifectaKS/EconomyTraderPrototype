namespace EconomyTraderPrototype.Market
{
    public class Market
    {
        public string Name { get; private set; }
        public IList<MarketGood> Goods { get; private set; }

        public Market(string marketName, IList<MarketGood> goods)
        {
            Name = marketName;
            Goods = goods;
        }

        public void TickMarket() 
        {
            foreach(var good in Goods)
            {
                //TODO: Check events for each good
                good.TickPrice();
            }
        }

        public void DebugLog()
        {
            Console.WriteLine("----------");

            Console.WriteLine($"Market: {Name}");
            foreach(var good in Goods)
                good.DebugLog();

            Console.WriteLine("----------");
        }
    }
}
