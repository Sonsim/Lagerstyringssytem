namespace Lagerstyringssytem
{
    internal class Matvare : IProdukt
    {
        DateTime utløpsdato;
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Matvare(string name, double price, System.DateTime date)
        {
            Navn = name;
            Pris = price;
            utløpsdato = date;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Type: {Navn}");
            Console.WriteLine($"Pris: {Pris},- kr.");
            Console.WriteLine($"Utløpsdato: {utløpsdato}");
            Console.WriteLine();
        }
    }
}
