using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._2._5_paran_neparan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                Console.WriteLine("Broje je paran!");
            }
            else
            {
                Console.WriteLine("Broja je neparan!");
            }
            Console.ReadKey();
        }
    }
}
