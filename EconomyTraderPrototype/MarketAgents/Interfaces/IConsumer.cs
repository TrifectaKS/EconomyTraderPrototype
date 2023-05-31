using EconomyTraderPrototype.Markets;
using EconomyTraderPrototype.Wallets;

namespace EconomyTraderPrototype.MarketAgents.Interfaces
{
    public interface IConsumer
    {
        IDictionary<MarketGood, IAgentGood> ConsumedGoods { get; }
        Wallet Wallet { get; }
        void Consume();
    }
}
