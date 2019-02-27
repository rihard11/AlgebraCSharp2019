using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._9_djelitelj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodni broj: ");
            int broj = int.Parse(Console.ReadLine());

            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
