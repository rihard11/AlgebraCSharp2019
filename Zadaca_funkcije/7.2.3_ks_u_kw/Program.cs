using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3_ks_u_kw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite snagu u konjskim snagama (KS): ");
            double ks = double.Parse(Console.ReadLine());

            Console.WriteLine("Snaga izražena u kilovatima (KW) je {0} KW.", KStoKW(ks));
            Console.ReadKey();
        }

        static double KStoKW(double ks)
        {
            return ks * 0.736;
        }

    }
}
