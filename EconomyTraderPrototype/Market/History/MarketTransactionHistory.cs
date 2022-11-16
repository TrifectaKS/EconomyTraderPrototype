namespace EconomyTraderPrototype.Market.History
{
    public class MarketTransactionHistory
    {
        public IList<TransationEntry> Transactions { get; private set; } = new List<TransationEntry>();

        public void AddTransaction(Order order)
        {
            Transactions.Add(new TransationEntry(DateTime.Now, order.OrderType, order.Good, order.Units, order.PricePerUnit));
        }

        public void DebugLog()
        {
            foreach (var transaction in Transactions)
                transaction.DebugLog();
        }
    }
}
