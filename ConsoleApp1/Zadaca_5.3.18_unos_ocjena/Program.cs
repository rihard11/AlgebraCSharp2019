using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_5._3._18_unos_ocjena
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena = 0;
            bool unosObavljen = false;

            while (!unosObavljen)
            {
                Console.WriteLine("Unesite ocjenu: ");
                ocjena = int.Parse(Console.ReadLine());

                if (ocjena == 1 || ocjena == 2 || ocjena == 3 || ocjena == 4 || ocjena == 5)
                {
                    unosObavljen = true;
                }
                else
                {
                    Console.WriteLine("Pogresan unos.");
                }
            }
            Console.WriteLine("Ocjena je unesena. Unjeli ste {0} kao ocjenu.", ocjena);
            Console.Read();
        }
    }
}

