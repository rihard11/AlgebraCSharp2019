using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_11._1._3._automobil
{
    class Automobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Zapremnina { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Boolean unos = true;
            List<Automobil> auti = new List<Automobil>();

            while (unos)
            {
                auti.Add(UnosAutomobila());

                Console.WriteLine("Želite li upisati novi automobil (d/n)?");

                unos = Console.ReadLine().ToLower() == "d";
            }
            List<string> modeliVelikeZapremnine = (
                from auto
                in auti
                orderby auto.Model
                where auto.Zapremnina > 1600
                select auto.Model).ToList();

            Console.WriteLine();
            Console.Write("Pronađeni automobili su: ");

            foreach (string model in modeliVelikeZapremnine)
            {
                Console.Write("{0} ,", model);
            }
            Console.ReadKey();
        }

        private static Automobil UnosAutomobila()
        {
            Automobil auto = new Automobil();

            Console.WriteLine("Unesite marku automobila: ");
            auto.Marka = Console.ReadLine();

            Console.WriteLine("Unesite model automobila: ");
            auto.Model = Console.ReadLine();

            Console.WriteLine("Unesite zapremninu automobila (ccm): ");
            auto.Zapremnina = int.Parse(Console.ReadLine());

            return auto;
        }
    }
}

