using EconomyTraderPrototype.Enums;
using EconomyTraderPrototype.Markets.Interfaces;

namespace EconomyTraderPrototype.Markets
{
    public class MarketOrder : IMarketEvent
    {
        public OrderType OrderType { get; private set; }
        public MarketGood Good { get; private set; }
        public int Units { get; private set; }
        public double PricePerUnit { get; private set; }

        //TODO Agent executing the order

        public MarketOrder(OrderType type, MarketGood good, int units, double pricePerUnit) 
        {
            OrderType = type;
            Good = good;
            Units = units;
            PricePerUnit = pricePerUnit;
        }

        public void OnComplete()
        {
            //TODO: Do something on order complete
            //Raise event for order complete
        }
    }
}
