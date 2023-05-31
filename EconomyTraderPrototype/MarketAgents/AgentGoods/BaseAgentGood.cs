using EconomyTraderPrototype.MarketAgents.Interfaces;
using EconomyTraderPrototype.Markets;

namespace EconomyTraderPrototype.MarketAgents.AgentGoods
{
    public abstract class BaseAgentGood : IAgentGood
    {
        public MarketGood Good { get; internal set; }
        public float Effeciency { get; internal set; }
        public double MinimumYield { get; internal set; }
        public double MaximumYield { get; internal set; }

        public void SetValues(MarketGood good, float effeciency, double minYield, double maxYield)
        {
            Good = good;
            Effeciency = effeciency;
            MinimumYield = minYield;
            MaximumYield = maxYield;
        }

        public void AddAgentGood(IAgentGood agentGood)
        {
            MinimumYield += agentGood.MinimumYield;
            MaximumYield += agentGood.MaximumYield;
            Effeciency = (Effeciency + agentGood.Effeciency)/2;
        }

        public abstract void TickAgentGood();
    }
}
