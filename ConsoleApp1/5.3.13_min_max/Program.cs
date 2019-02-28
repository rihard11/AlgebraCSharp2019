using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._13_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int broj;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Unesite {0}. prirodni broj: ", i);
                broj = int.Parse(Console.ReadLine());

                if (broj < min)
                {
                    min = broj;
                }
                if (broj > max)
                {
                    max = broj;
                }
            }
            Console.WriteLine("Najmanji = {0}\nNajveći = {1}", min, max);
            Console.ReadKey();
        }
    }
}
