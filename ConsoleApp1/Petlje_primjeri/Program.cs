using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ispis svih brojeva 0, 1, 2... 99
            /*
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("Ispis svih rojeva 16, 18....88");
            // Ispis svih brojeva 16, 18, 20... 88
            for (int i = 16; i < 89; i+=2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("Ispis svih rojeva 135, 130....55");
            // Ispis svih brojeva 16, 18, 20... 88
            for (int i = 135; i > 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }
            

            Console.WriteLine("Ispis svih rojeva osim broja 80");
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\nIspis svih rojeva ..break 80");
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }

            // ispis svih brojeva  do 9999 koji su djeljivi sa 17

            Console.WriteLine("\nIspis svih rojeva ..9999 djeljivih sa 17");
            for (int i = 0; i < 10000; i++)
            {
                if (i % 17 == 0 && i % 13 == 0 )
                {
                    
                    Console.Write("{0} ", i);
                }
            }
            */

            Console.WriteLine("\n Tablica množenja");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("{0}\t", i * j);
                }
                Console.WriteLine();
            }

            //Sume brojeva 
            Console.WriteLine("\n Suma brojeva");
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", suma += i);
            }

            Console.ReadKey();
        }
    }
}
