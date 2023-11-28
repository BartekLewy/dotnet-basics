namespace Basics
{
    class Wallet
    {
        private Money state;

        public Wallet()
        {
            state = new Money(Currency.USD);
        }

        public Money getState()
        {
            return state;
        }
        public void AddMoney(Money money)
        {
            state.add(money);
        }
        public void RemoveMoney(Money money)
        {
            if (money.getValue() > state.getValue())
            {
                throw new ArgumentException("Not enough money");
            }
            state.subtract(money);
        }
    }
}
