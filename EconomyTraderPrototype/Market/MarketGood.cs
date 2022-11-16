namespace EconomyTraderPrototype.Market
{
    public class MarketGood
    {
        public string Name { get; }
        public double BasePrice { get; }
        public double Minimum { get; }
        public double Maximum { get; }

        public double Price { get; private set; }
        public int Supply { get; private set; } = 0;
        public int Demand { get; private set; } = 0;

        private int Balance => Supply - Demand;

        private double _targetPrice;


        public IList<double> PriceHistory { get; private set; } = new List<double>();

        public MarketGood(string name, double basePrice)
        {
            Name = name;
            Minimum = basePrice - (basePrice * MarketConstants.PriceCapMargin);
            Maximum = basePrice + (basePrice * MarketConstants.PriceCapMargin);

            Price = basePrice;
            BasePrice = basePrice;
            _targetPrice = basePrice;
        }

        public void AddSupply(int supply)
        {
            Supply += supply;
            updateTargetPrice();
        }

        public void AddDemand(int demand)
        {
            Demand += demand;
            updateTargetPrice();
        }

        public void TickPrice()
        {
            if (Price == _targetPrice)
                return;

            Price = MarketHelpers.InterpolateDouble(MarketConstants.PriceInterpolation, Price, _targetPrice);

            if(Math.Abs(_targetPrice - Price) <= MarketConstants.PriceSnap)
            {
                Price = _targetPrice;
            }
        }

        private void setPriceToTarget()
        {
            Price = _targetPrice;
        }

        private double calculateModifier(double balance, double quantity)
        {
            return (balance / quantity) * -MarketConstants.PriceCapMargin;
        }

        private void updateTargetPrice()
        {
            var balance = Balance;
            double modifier = 1;
            if (balance > 0)
            {
                modifier = calculateModifier(balance, Supply);
                
            }
            else if(balance < 0)
            {
                modifier = calculateModifier(balance, Demand);
            }

            _targetPrice = BasePrice + (BasePrice * modifier);
        }

        public void DebugLog()
        {
            Console.WriteLine($"MarketGood: {Name} @ ${Price} per unit");
        }
    }
}
