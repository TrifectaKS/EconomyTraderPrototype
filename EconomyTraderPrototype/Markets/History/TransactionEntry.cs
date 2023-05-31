using EconomyTraderPrototype.Enums;

namespace EconomyTraderPrototype.Markets.History
{
    public class TransationEntry
    {
        public DateTime When { get; private set; }
        public OrderType OrderType { get; private set; }
        public MarketGood MarketGood { get; private set; }
        public int Amount { get; private set; }
        public double PricePerUnit { get; private set; }

        public TransationEntry(DateTime when, OrderType type, MarketGood good, int amount, double price)
        {
            When = when;
            OrderType = type;
            MarketGood = good;
            Amount = amount;
            PricePerUnit = price;
        }

        public void DebugLog()
        {
            Console.WriteLine($"TransactionEntry: {When} - {OrderType} - {MarketGood.Name} - {Amount} @ ${PricePerUnit} per unit");
        }
    }
}
