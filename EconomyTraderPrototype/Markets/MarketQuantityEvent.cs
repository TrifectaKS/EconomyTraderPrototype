using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomyTraderPrototype.Markets.Interfaces;

namespace EconomyTraderPrototype.Markets
{
    public class MarketQuantityEvent : IMarketEvent
    {
        public MarketGood Good { get; private set; }
        public int SupplyShift { get;private set; }
        public int DemandShift { get;private set; }

        public MarketQuantityEvent(MarketGood good, int supplyShift = 0, int demandShift = 0)
        {
            Good = good;
            SupplyShift = supplyShift;
            DemandShift = demandShift;
        }

        public void OnComplete()
        {
            if(Good == null) return;

            Good.AddSupply(SupplyShift);
            Good.AddDemand(DemandShift);
        }
    }
}
