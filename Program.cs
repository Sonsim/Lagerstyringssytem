namespace Lagerstyringssytem
{
    internal class Program
    {
        public static Lager test = new Lager();
        public static Matvare Ost = new Matvare("Jarlsberg", 119, new DateTime(2024, 02, 05));
        public static Matvare Melk = new Matvare("Lettmelk 1L", 20, new DateTime(2024, 01, 10));

        public static Klær Jakke = new Klær("L", "Jakke", 400);
        public static Klær Bukse = new Klær("L", "Bukse", 300);

        public static Elektronikk Telefon = new Elektronikk("Mobil", 2000, 12);
        public static Elektronikk PC = new Elektronikk("PC", 10000, 24);


        


        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Legge til produkt i lageret");
            Console.WriteLine("2. Fjerne et produkt fra lageret");
            Console.WriteLine("3. Liste opp alle produkter i lageret");
            Console.WriteLine("4. Avslutt");
            var ans = Convert.ToInt32(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    Console.Clear();
                    test.leggtilprodukt();
                    break;
                case 2:
                    Console.Clear();
                    test.RemoveProdct();
                    break;
                case 3:
                    Console.Clear();
                    test.ShowAllProducts();
                    break;
                default:
                    System.Environment.Exit(0);
                    break;

            }
        }

    }
}