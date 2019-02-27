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
            int min = int.MinValue;
            int max = int.MaxValue;
            int b;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Unesite {0}. prirodni broj", i);
                b = int.Parse(Console.ReadLine());

                if (b < min)
                {
                    min = b;
                }
                if (b > max)
                {
                    max = b;
                }
            }
            Console.WriteLine("Najmanji: {0}\n Najveći: {1}", min, max);
            Console.ReadKey();
        }
    }
}
