namespace Basics
{
    class WalletFormatter
    {
        public static string Format(Wallet wallet) {
            return (double) wallet.getState().getValue() / 100 + 
                wallet.getState().getCurrency().ToString()
            ;
        }
    }
}
