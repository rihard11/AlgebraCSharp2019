using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3_ks_u_kw_obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite snagu u KW (kilovatima): ");
            double kw = double.Parse(Console.ReadLine());

            Console.WriteLine("Snaga izražena u konjskim snagama (KS) je {0} KS", KWtoKS(kw));
            Console.ReadKey();
        }

        static double KWtoKS(double kw)
        {
            return Math.Round(kw / 0.736);
        }
    }
}
