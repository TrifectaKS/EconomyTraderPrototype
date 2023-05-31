using EconomyTraderPrototype.Markets;

namespace EconomyTraderPrototype.Factories
{
    public static class MarketGoodFactory
    {
        public static MarketGood CreateMarketGood(string name, double basePrice)
        {
            return new MarketGood(name, basePrice);
        }

        public static MarketGood CreateMarketGood(string name, double basePrice, int initialSupply, int initialDemand)
        {
            var good = new MarketGood(name, basePrice);
            good.AddSupply(initialSupply);
            good.AddDemand(initialDemand);
            return good;
        }

        public static IList<MarketGood> CreateMarketGoods(IDictionary<string, double> goodsData)
        {
            var goods = new List<MarketGood>();
            foreach(KeyValuePair<string, double> pair in goodsData)
            {
                goods.Add(CreateMarketGood(pair.Key, pair.Value));
            }
            return goods;
        }
    }
}
