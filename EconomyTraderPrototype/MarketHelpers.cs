namespace EconomyTraderPrototype
{
    public class MarketHelpers
    {
        public static double InterpolateDouble(double interval, double currentVal, double targetVal)
        {
            return currentVal + (interval * (targetVal - currentVal));
        }
    }
}
