using EconomyTraderPrototype.Markets;
using EconomyTraderPrototype.Wallets;

namespace EconomyTraderPrototype.MarketAgents.Interfaces
{
    public interface IProducer
    {
        IDictionary<MarketGood, IAgentGood> ProducedGoods { get; }
        Wallet Wallet { get; }
        public void Produce();
    }
}
