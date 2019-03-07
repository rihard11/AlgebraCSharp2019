using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_automobil_zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto1 = new Automobil();

            Console.Write("Unesite marku automobila: ");
            auto1.markaAutomobila = Console.ReadLine();

            Console.Write("Unesite KS: ");
            auto1.KS = double.Parse(Console.ReadLine());

            Console.Write("Unesite osnovnu cijenu: ");
            auto1.osnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Iznod poreza na automobil: {0} " +
                "\nUkupna cijena automobila: {1}", auto1.IznosPoreza(), auto1.UkupnaCijena());

            Console.ReadKey();
        }
    }
}
