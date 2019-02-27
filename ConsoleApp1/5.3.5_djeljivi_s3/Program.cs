using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._5_djeljivi_s3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi iz intervala od 1 do 100 djeljivi sa 3 su: ");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
