using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssytem
{
    internal class Lager
    {
         public static List<IProdukt> produktliste = new List<IProdukt>
         {
             Program.Ost,Program.Bukse,Program.Jakke, Program.Melk, Program.PC, Program.Telefon
         };

      

        public void leggtilprodukt()
        {
            Console.WriteLine("Hva slags produkt ønsker du å legge til?");
            Console.WriteLine($"1. Klær");
            Console.WriteLine($"2. Mat");
            Console.WriteLine($"3. Elektronikk");
            Console.WriteLine($"4. Tilbake til meny");
            var ans = Convert.ToInt32(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    CreateNewClothes();
                    break;
                case 2:
                    CreateNewFood();
                    break;
                case 3:
                    CreateNewElectronics();
                    break;
                case 4:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }

        public void ShowAllProducts()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Alle produkter i lageret;");
            ListAll();

            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }

        public void RemoveProdct()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Hvilket produkt vil du fjerne? Skriv navnet til varen");

            for (int i = 0; i < produktliste.Count; i++)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine($"{i}. {produktliste[i].Navn}");
            }

            var choice = Console.ReadLine();
            

            for (int i = 0; i < produktliste.Count; i++)
            {
                if (choice.ToLower() == produktliste[i].Navn.ToLower())
                {
                    produktliste.Remove(produktliste[i]);
                    Console.Clear();
                    Program.Menu(); 
                    
                }
            }

            
        }

        private void ListAll()
        {
            for (int i = 0; i < produktliste.Count; i++)
            {
                Console.WriteLine("********************************************");
                produktliste[i].SkrivUtInfo();
            }
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }

        private void CreateNewElectronics()
        {
            Console.WriteLine("Hva slags elektronikk er det?");
            string name = Console.ReadLine();
            Console.WriteLine("Hva koster varen?");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hvor mange måneder garanti er det?");
            var warranty = Convert.ToInt32(Console.ReadLine());

            var newelec = new Elektronikk(name, price, warranty);
            produktliste.Add(newelec);
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }

        private void CreateNewFood()
        {
            Console.WriteLine("Hva slags mat er det?");
            string name = Console.ReadLine();
            Console.WriteLine("Hva koster varen?");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Når går varen ut på dato? YYYY/MM/DD");
            var date = Convert.ToDateTime(Console.ReadLine());

            var newfood = new Matvare(name, price, date);
            produktliste.Add(newfood);
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }

        private void CreateNewClothes()
        {
            Console.WriteLine("Hvilken størrelse har plagget?");
            string size = Console.ReadLine();
            Console.WriteLine("Hva heter plagget?");
            string name = Console.ReadLine();
            Console.WriteLine("Hvor mye koster varen?");
            double price = Convert.ToDouble(Console.ReadLine());

            var newclothes = new Klær(size, name, price);
            produktliste.Add(newclothes);
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }
    }
}
