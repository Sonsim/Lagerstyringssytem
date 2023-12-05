namespace Lagerstyringssytem
{
    internal class Klær : IProdukt

    {
    private string _size;
    public string Navn { get; set; }
    public double Pris { get; set; }

    public Klær(string Size, string Name, double Price)
    {
        _size = Size;
        Navn = Name;
        Pris = Price;
    }
    public void SkrivUtInfo()
    {
        Console.WriteLine($"Type plagg: {Navn}");
        Console.WriteLine($"Størrelse: {_size}");
        Console.WriteLine($"Pris: {Pris},- kr.");
        Console.WriteLine();
    }
    }
}
