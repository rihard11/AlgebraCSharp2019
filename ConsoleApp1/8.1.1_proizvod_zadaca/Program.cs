using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1_proizvod_zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod();

            Console.Write("Unesite naziv proizvoda: ");
            p1.naziv = Console.ReadLine();

            Console.Write("Unesite cijenu proizvoda: ");
            p1.cijena = double.Parse(Console.ReadLine());

            Console.Write("Unesite marzu proizvoda: ");
            p1.marza = double.Parse(Console.ReadLine());

            Console.Write("Unesite porez na proizvod: ");
            p1.porez = double.Parse(Console.ReadLine());

            // Ispis
            Console.WriteLine("Maloprodajna cijena za proizvod {0} je {1}", p1.naziv, p1.MPC());
            Console.ReadKey();
        }
    }
}
