using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._8_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite jedan prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", broj, Faktorijel(broj));
            Console.ReadKey();
        }

        static int Faktorijel(int broj)
        {
            if (broj == 1)
            {
                return broj;

            }
            else
            {
                return broj * Faktorijel(broj - 1);
            }
        }
    }
}
