using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._9_prosjek_obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            Console.Write("Unesite prosječnu ocjenu riječju: ");
            string prosjecnaOcjena = Console.ReadLine().ToLower();

            Console.WriteLine("Posječna ocjena je {0}.", Ocjena(prosjecnaOcjena));
            Console.ReadKey();
        }

        static string Ocjena(string prosjecnaOcjena)
        {
            if (prosjecnaOcjena == "nedovoljan")
            {
                return "1";

            }
            else if (prosjecnaOcjena == "dovoljan")
            {
                return "2";
            }
            else if (prosjecnaOcjena == "dobar")
            {
                return "3";
            }
            else if (prosjecnaOcjena == "vrlodobar")
            {
                return "4";
            }
            else 
            {
                return "5";
            }
            
        }
    }
}
