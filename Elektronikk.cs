namespace Lagerstyringssytem
{
    internal class Elektronikk : IProdukt
    {
        private int _garantitid;
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Elektronikk(string name, double price, int warranty)
        {
            Navn = name;
            Pris = price;
            _garantitid=warranty;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Type: {Navn}");
            Console.WriteLine($"Pris: {Pris},- kr");
            Console.WriteLine($"Antall mnd garnati: {_garantitid}");
            Console.WriteLine();
        }
    }
}
