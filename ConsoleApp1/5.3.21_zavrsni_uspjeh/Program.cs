using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._21_zavrsni_uspjeh
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            string ocjena = "";
            bool nedovoljan = false;

            Console.WriteLine("Unesite broj predmeta za koje unosite ocjene: ");
            int brojOcjena = int.Parse(Console.ReadLine());

            for (int i = 1; i <= brojOcjena; i++)
            {
                bool unosObavljen = false;

                while (!unosObavljen)
                {
                    Console.WriteLine("Unesite {0} ocjenu: ", i);
                    ocjena = Console.ReadLine();

                    if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")
                    {
                        unosObavljen = true;
                    }
                    else
                    {
                        Console.WriteLine("Pogrešan unos");
                    }
                }

                if (ocjena == "1")
                {
                    nedovoljan = true;
                    break; // Prekid
                }
                else
                {
                    suma += int.Parse(ocjena);
                }
            }
            if (nedovoljan)
            {
                Console.WriteLine("Uspjeh je nedovoljan");
            }
            else
            {
                Console.WriteLine("Prosjek je {0}.", (double)suma / brojOcjena);
            }
            Console.ReadKey();
        }
    }
}
