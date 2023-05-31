using EconomyTraderPrototype.Markets;

namespace EconomyTraderPrototype.MarketAgents.Interfaces
{
    public interface IAgentGood
    {
        public MarketGood Good { get; }
        public float Effeciency { get; }
        public double MinimumYield { get; }
        public double MaximumYield { get; }

        public void AddAgentGood(IAgentGood agentGood);
        public void TickAgentGood();
    }
}
