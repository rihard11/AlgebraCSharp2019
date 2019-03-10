using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_za_11._03._19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> listaUcenika = new List<Ucenik>
            {
            new Ucenik("Dino", "Galic"),
            new Ucenik("Hana", "Horvatic", 123456789),
            new Ucenik("Ina", "Milic", 987654321, 6500)
            };
            listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));

            Console.WriteLine("Unesite skolarinu: ");
            int skoloarina = int.Parse(Console.ReadLine());
            listaUcenika.ForEach(Ucenik => Ucenik.Racun -= skoloarina);
            foreach (var item in listaUcenika)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }

        // Ispis
        private static void IspisUcenika(Ucenik ucenik)
        {
            Console.WriteLine("Ucenik: " + ucenik.Ime + " " + ucenik.Prezime);
            Console.WriteLine("Stanje na racunu: " + ucenik.Racun);
        }
    }
}
