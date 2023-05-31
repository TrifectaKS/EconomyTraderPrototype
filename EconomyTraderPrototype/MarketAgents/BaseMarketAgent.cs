using EconomyTraderPrototype.MarketAgents.Interfaces;
using EconomyTraderPrototype.Markets;
using EconomyTraderPrototype.Wallets;

namespace EconomyTraderPrototype.MarketAgents
{
    public abstract class BaseMarketAgent : IConsumer, IProducer
    {
        public Wallet Wallet { get; internal set; }
        public IDictionary<MarketGood, IAgentGood> ConsumedGoods { get; internal set; }
        public IDictionary<MarketGood, IAgentGood> ProducedGoods { get; internal set; }

        public BaseMarketAgent()
        {
            ConsumedGoods = new Dictionary<MarketGood, IAgentGood>();
            ProducedGoods = new Dictionary<MarketGood, IAgentGood>();
            Wallet = new Wallet(0);
        }

        public BaseMarketAgent(double initialMoney, IList<IAgentGood> consumedGoods, IList<IAgentGood> producedGoods) : this()
        {
            SetValues(initialMoney, consumedGoods, producedGoods);
        }

        public void SetValues(double initialMoney, IList<IAgentGood> consumedGoods, IList<IAgentGood> producedGoods)
        {
            Wallet.SetMoney(initialMoney);

            foreach (IAgentGood good in consumedGoods)
            {
                AddConsumedGood(good);
            }

            foreach (IAgentGood good in producedGoods)
            {
                AddProducedGood(good);
            }
        }

        public void RemoveConsumedGood(MarketGood good)
        {
            ConsumedGoods.Remove(good);
        }

        public void RemoveProducedGood(MarketGood good)
        {
            ProducedGoods.Remove(good);
        }

        public void AddConsumedGood(IAgentGood agentGood)
        {
            if (ConsumedGoods.ContainsKey(agentGood.Good))
                ConsumedGoods[agentGood.Good].AddAgentGood(agentGood);
            else
                ConsumedGoods.Add(agentGood.Good, agentGood);
        }

        public void AddProducedGood(IAgentGood agentGood)
        {
            if (ProducedGoods.ContainsKey(agentGood.Good))
                ProducedGoods[agentGood.Good].AddAgentGood(agentGood);
            else
                ProducedGoods.Add(agentGood.Good, agentGood);
        }

        public abstract void Consume();

        public abstract void Produce();
    }
}
