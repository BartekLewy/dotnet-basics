// See https://aka.ms/new-console-template for more information
using Basics;

Vin vinAudi = new Vin("WAUZZZ01234567890");

Vin vinOpl = new Vin("WAUZZZ01234567812");

if(vinAudi.Equals(vinOpl))
{
    Console.WriteLine("Panie!");
}
else
{
    Console.WriteLine("Gites!");
}

try 
{ 
    Vin przebity = new AudiVin("WAUZZZ0123456784A");
    Console.WriteLine(przebity.Get());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

