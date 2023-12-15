namespace Basics
{
    class Vin : IEquatable<Vin>
    {
        private const int CorrectVinLength = 17;
        private readonly string vin;
        private readonly static char[] characters = { 'I', 'O', 'Q' };
        public Vin(string vin)
        {
            vin = vin.ToUpper();
            if(vin.Length != CorrectVinLength)
            {
                throw new ArgumentException("Nieprawidłowa długośc numeru vin.");
            }
            if (characters.Any(character => vin.Contains(character)))
            {
                throw new ArgumentException("Numer vin nie może zawierać litery I, O oraz Q.");
            }
            this.vin = vin;
        }

        public bool Equals(Vin? other)
        {
            if(other == null)
            {
                return false;
            }
            return vin == other.vin;
        }

        public string Get()
        {
            return this.vin;
        }
    }
}
