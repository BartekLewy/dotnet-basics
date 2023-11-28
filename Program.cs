// See https://aka.ms/new-console-template for more information
using Basics;

// USD
var wallet = new Wallet();

var piatak = new Money(500, Currency.USD);

wallet.AddMoney(piatak);
wallet.RemoveMoney(new Money(360, Currency.USD));

Console.WriteLine(WalletFormatter.Format(wallet));