using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_5._3._20_par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            int parni = 0;
            int neparni = 0;

            while (broj != 0)
            {
                try
                {
                    Console.Write("Unesi prirodni broj: ");
                    broj = int.Parse(Console.ReadLine());
                    if (broj % 2 == 0 && broj != 0)
                    {
                        parni++;
                    }
                    else if (broj % 2 != 0 && broj != 0)
                    {
                        neparni++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Niste unjeli broj!" + ex.ToString());
                }
            }
            Console.WriteLine("Broj parnih brojeve je {0}", parni);
            Console.WriteLine("Broj neparnih brojeva je {0}", neparni);
            Console.ReadLine();
        }
    }
}
