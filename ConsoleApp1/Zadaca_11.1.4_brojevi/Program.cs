using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_11._1._4_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();
            int unos = -1;

            while (unos != 0)
            {
                Console.WriteLine("Unesite broj:");
                unos = int.Parse(Console.ReadLine());
                if (unos != 0)
                {
                    brojevi.Add(unos);
                }
            }
            int brojParnih = (
                from broj 
                in brojevi
                where broj % 2 == 0
                select broj).Count();

            int brojNeparnih = brojevi.Count - brojParnih;

            Console.WriteLine("Broj parnih brojeva je {0}, a neparnih {1}", brojParnih, brojNeparnih);

            Console.ReadKey();
        }
    }
}
