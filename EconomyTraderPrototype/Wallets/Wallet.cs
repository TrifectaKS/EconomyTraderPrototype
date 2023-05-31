namespace EconomyTraderPrototype.Wallets
{
    public class Wallet
    {
        //TODO: Wallet owner
        public double Money { get; private set; }

        public Wallet(double initialMoney)
        {
            Money = initialMoney;
        }

        public void AddMoney(double amount)
        {
            Money += amount;
        }

        public void SetMoney(double amount)
        {
            Money = amount;
        }
    }
}
