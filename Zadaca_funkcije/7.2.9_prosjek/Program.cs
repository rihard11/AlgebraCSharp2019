using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._9_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prosječnu ocjenu: ");
            double broj = double.Parse(Console.ReadLine());

            Console.WriteLine("Prosjek je {0}.", Prosjek(broj));
            Console.ReadKey();
        }

        static string Prosjek(double broj)
        {
            string prosjek = "";

            if (broj < 2)
            {
                prosjek = "nedovoljan";

            }
            else if (broj < 2.5)
            {
                prosjek = "dovoljan";
            }
            else if (broj < 3.5)
            {
                prosjek = "dobar";
            }
            else if (broj < 4.5)
            {
                prosjek = "vrlo dobar";
            }
            else
            {
                prosjek = "odličan";
            }

            return prosjek;
        }
    }
}
