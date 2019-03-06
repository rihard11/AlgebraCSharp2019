using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._6_prost_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite jedan prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (Prost(broj))
            {
                Console.WriteLine("Broj je Prost.");

            }
            else
            {
                Console.WriteLine("Broj je Složen.");
            }

            Console.ReadKey();
        }

        static bool Prost(int broj)
        {
            bool prost = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }
    }
}
