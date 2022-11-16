using EconomyTraderPrototype.Enums;

namespace EconomyTraderPrototype.Market
{
    public class Order
    {
        public OrderType OrderType { get; private set; }
        public MarketGood Good { get; private set; }
        public int Units { get; private set; }
        public double PricePerUnit { get; private set; }

        public Order(OrderType type, MarketGood good, int units, double pricePerUnit) 
        {
            OrderType = type;
            Good = good;
            Units = units;
            PricePerUnit = pricePerUnit;
        }

        public void OnComplete()
        {
            //TODO: Do something on order complete
            //Add to inventory,
            //Decrease player currency etc.
        }
    }
}
