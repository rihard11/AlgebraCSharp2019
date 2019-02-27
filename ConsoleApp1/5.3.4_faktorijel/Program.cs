using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            int a = int.Parse(Console.ReadLine());

            long fakt = 1;

            for (int i = 1; i <= a; i++)
            {
                fakt *= i;
            }
            Console.WriteLine("{0}! = {1}", a, fakt);
            Console.ReadKey();   
        }
    }
}
