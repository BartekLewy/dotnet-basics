namespace Basics
{
    class Money
    {
        private int value;
        private Currency currency;

        public Money(Currency currency)
        {
            value = 0;
            this.currency = currency;
        }

        public Money(int money, Currency currency)
        {
            if (money < 1)
            {
                throw new ArgumentException("We accept only positive integer values");
            }

            value = money;
            this.currency = currency;
        }

        public void add(Money money)
        {
            assertSameCurrency(money);

            value += money.value;
        }

        public void subtract(Money money)
        {
            assertSameCurrency(money);

            value -= money.value;
        }

        public int getValue()
        {
            return value;
        }

        public Currency getCurrency()
        {
            return currency;
        }

        private void assertSameCurrency(Money money)
        {
            if (!currency.Equals(money.currency))
            {
                throw new ArgumentException("Divergent currency");
            }
        }
    }
}