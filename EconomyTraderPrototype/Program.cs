// See https://aka.ms/new-console-template for more information
using EconomyTraderPrototype;
using EconomyTraderPrototype.Factories;
using EconomyTraderPrototype.MarketAgents;
using EconomyTraderPrototype.MarketAgents.AgentGoods;
using EconomyTraderPrototype.MarketAgents.Interfaces;
using EconomyTraderPrototype.Markets;

Console.WriteLine("Market Simulator");

string? input = "";

Randomizer.SetSeed(123);

var goods = new Dictionary<string, MarketGood>()
{
    { "Coal", MarketGoodFactory.CreateMarketGood("Coal", 100, 1000, 750) },
    { "Meat", MarketGoodFactory.CreateMarketGood("Meat", 75, 400, 450) },
};


var marketAgents = new Dictionary<string, BaseMarketAgent>() {
    { "Farmer 1", MarketAgentFactory.CreateAgent<Farmer>(5,
        new List<IAgentGood> ()
        {
            AgentGoodFactory.CreateAgentGood<AgentConsumptionGood>(goods["Meat"], 100, 1, 5),
            AgentGoodFactory.CreateAgentGood<AgentConsumptionGood>(goods["Coal"], 100, 100, 200),
        },
        new List<IAgentGood> ()
        {
            AgentGoodFactory.CreateAgentGood<AgentProductionGood>(goods["Meat"], 100, 50, 100) ,
        })
    },

    { "Farmer 2", MarketAgentFactory.CreateAgent<Farmer>(5,
        new List<IAgentGood> ()
        {
            AgentGoodFactory.CreateAgentGood<AgentConsumptionGood>(goods["Meat"], 100, 5, 7),
            AgentGoodFactory.CreateAgentGood<AgentConsumptionGood>(goods["Coal"], 55, 20, 75),
        },
        new List<IAgentGood> ()
        {
            AgentGoodFactory.CreateAgentGood<AgentProductionGood>(goods["Meat"], 75, 50, 100),
        })
    },

    { "Socialite", MarketAgentFactory.CreateAgent<Farmer>(5,
        new List<IAgentGood> ()
        {

        },
        new List<IAgentGood> ()
        {
            AgentGoodFactory.CreateAgentGood<AgentProductionGood>(goods["Meat"], 100, 100, 200),
        })
    },
};

Market market = new Market("Market 1", goods, marketAgents);

do
{
    input = Console.ReadLine();

    switch (input)
    {
        case "t":
            market.TickMarket();
            market.DebugLog();
            break;
        case "d":
            goods["Meat"].AddDemand(10); break;
        case "s":
            goods["Meat"].AddSupply(10); break;
        default: break;
    }

} while (input != "exit");
