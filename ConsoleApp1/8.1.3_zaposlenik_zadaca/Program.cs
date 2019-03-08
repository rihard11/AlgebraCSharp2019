using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_zaposlenik_zadaca
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instanciranje novog objekta Z1 klase Zaposlenik
            Zaposlenik Z1 = new Zaposlenik("Marko", "Marić", "1234567890123");

            // Korisnik mora ispravno unijeti broj bodova
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite broj bodova: ");

                try
                {
                    Z1.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
            }


            provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite vrijednost boda: ");

                try
                {
                    Z1.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
            }

            // Ispis
            Console.WriteLine("Zaposlenik: " + Z1.Ime + "" + Z1.Prezime);
            Console.WriteLine("Neto: " + Z1.NetoIzracunPlace());
            Console.WriteLine("Porez: " + Z1.Porez);
            Console.WriteLine("Bruto: " + Z1.BrutoIzracunPlace());

            Console.ReadKey();
        }
    }
}
