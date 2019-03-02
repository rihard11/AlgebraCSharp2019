using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_5._3._12_suma__i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Unesite {0} broj: ", i);
                    suma += int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Suma ovih brojeva je: {0} " +
                    "\nProsjek ovih brojeva je {1}", suma, suma / 5);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska. Niste unjeli broj. " + ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
