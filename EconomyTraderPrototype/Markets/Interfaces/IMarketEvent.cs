namespace EconomyTraderPrototype.Markets.Interfaces
{
    public interface IMarketEvent
    {
        MarketGood Good { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        void OnComplete();
    }
}
