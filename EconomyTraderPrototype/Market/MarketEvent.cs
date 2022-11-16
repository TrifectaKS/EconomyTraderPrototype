namespace EconomyTraderPrototype.Market
{
    public class MarketEvent
    {
        public MarketGood MarketGood { get; private set; }
        public double? Multiplier { get; private set; }

        public int? Trend { get; private set; }
        public double? TargetPrice { get; private set; }

        public MarketEvent(MarketGood good, double multiplier)
        {
            MarketGood = good;
            Multiplier = multiplier;
        }

        public MarketEvent(MarketGood good, int trend, double targetPrice)
        {
            MarketGood = good;
            Trend = trend;
            TargetPrice = targetPrice;
        }
    }
}
