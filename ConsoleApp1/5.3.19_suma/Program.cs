using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._19_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int broj = 1;

            while (broj != 0)
            {
                Console.Write("Unesite prirodan broj: ");
                broj = int.Parse(Console.ReadLine());
                suma += broj;
            }
            Console.WriteLine("Suma unašenih brojeva je {0}", suma);
            Console.ReadKey();
        }
    }
}
