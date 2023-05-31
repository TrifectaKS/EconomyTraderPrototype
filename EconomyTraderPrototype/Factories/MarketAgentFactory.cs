using EconomyTraderPrototype.MarketAgents;
using EconomyTraderPrototype.MarketAgents.Interfaces;

namespace EconomyTraderPrototype.Factories
{
    public static class MarketAgentFactory
    {
        public static T CreateAgent<T>(double initialMoney, IList<IAgentGood> consumedGoods, IList<IAgentGood> producedGoods) where T : BaseMarketAgent, new()
        {
            var agent = new T();
            agent.SetValues(initialMoney, consumedGoods, producedGoods);
            return agent;
        }
    }
}
