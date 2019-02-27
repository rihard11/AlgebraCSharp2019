using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._11_savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Savršeni brojevi iz intervala 1 do 1000 su: ");
            int broj;

            for (int i = 1; i <= 1000; i++)
            {
                broj = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        broj += j;
                    }
                }
                if (i == broj)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
