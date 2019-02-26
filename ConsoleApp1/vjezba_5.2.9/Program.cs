﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj;

            try
            {

                broj = int.Parse(Console.ReadLine());

                if (broj % 2 == 0)
                {
                    Console.WriteLine("Broj je paran");
                }
                

                if (broj % 3 == 0)
                {
                    Console.WriteLine("Broj je djeljiv s 3");
                }
                else
                {
                    Console.WriteLine("Broj {0} nije djeljiv sa 3, ostatak je {1}", broj, (broj % 3));
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Provjeri je li unešen broj? " + e.ToString());
            }
            Console.ReadKey();
        }
    }
}
