using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._10_ukupna_cijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ulaznu cijenu: ");
            double ulaznaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Ukupna cijena je {0}.", UkupnaCijena(ulaznaCijena));
            Console.ReadKey();
        }

        static double Marza(double ulaznaCijena)
        {
            double marza = 0;

            if (ulaznaCijena < 100)
            {
                marza = 5.5;
            }
            else if (ulaznaCijena < 250)
            {
                marza = 9.5;
            }
            else if (ulaznaCijena < 500)
            {
                marza = 15;
            }
            else if (ulaznaCijena < 1000)
            {
                marza = 25;
            }
            else
            {
                marza = 50;
            }

            return marza;
        }

        static double Porez(double ulaznaCijena)
        {
            double porez = 0;

            if (ulaznaCijena < 100)
            {
                porez = 0.02 * ulaznaCijena;
            }
            else if (ulaznaCijena < 250)
            {
                porez = 0.03 * ulaznaCijena;
            }
            else if (ulaznaCijena < 500)
            {
                porez = 0.04 * ulaznaCijena;
            }
            else if (ulaznaCijena < 1000)
            {
                porez = 0.05 * ulaznaCijena;
            }
            else
            {
                porez = 0.1 * ulaznaCijena;
            }

            return porez;
        }

        static double UkupnaCijena(double ulaznaCijena)
        {
            return ulaznaCijena + Marza(ulaznaCijena) + Porez(ulaznaCijena) + ulaznaCijena * 0.22;
        }
    }
}
