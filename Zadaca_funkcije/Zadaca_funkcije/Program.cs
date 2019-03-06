using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_funkcije
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite radijus kruga: ");
            double rad = double.Parse(Console.ReadLine());

            Console.WriteLine("Opseg kruga s radijusom {0} je {1}.", rad, Math.Round(OpsegKruga(rad), 2));
            Console.WriteLine("Povrsina kruga s radijusom {0} je {1}", rad, Math.Round(PovrsinaKruga(rad), 2));
            Console.ReadKey();
        }

        static double OpsegKruga(double rad)
        {
            return 2 * rad * Math.PI;
        }
        static double PovrsinaKruga(double rad)
        {
            return rad * rad * Math.PI;
        }


    }
}
