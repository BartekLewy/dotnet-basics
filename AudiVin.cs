namespace Basics
{
    internal class AudiVin : Vin
    {

        public AudiVin(string vin) : base(vin)
        {
            if(!vin.StartsWith("WAUZZZ"))
            {
                throw new ArgumentException("Niepoprawny VIN dla Audi.");
            }
        }
    }
}
