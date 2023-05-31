using EconomyTraderPrototype.MarketAgents.AgentGoods;
using EconomyTraderPrototype.Markets;

namespace EconomyTraderPrototype.Factories
{
    public static class AgentGoodFactory
    {
        public static T CreateAgentGood<T>(MarketGood good, float effeciency, double minYield, double maxYield) where T : BaseAgentGood, new()
        {
            var agentGood = new T();
            agentGood.SetValues(good, effeciency, minYield, maxYield);
            return agentGood;
        }
    }
}
