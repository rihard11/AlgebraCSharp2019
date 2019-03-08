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
            Zaposlenik Z2 = new Zaposlenik("Luka", "Lukić");

            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika.Add(Z1);
            listaZaposlenika.Add(Z2);

            listaZaposlenika.ForEach(Zaposlenik => UnesiBodove(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => UnesiVrijednostBoda(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => IspisiZaposlenike(Zaposlenik));
       

            Console.ReadKey();
        }

        private static void IspisiZaposlenike(Zaposlenik zaposlenik)
        {
            // Ispis
            Console.WriteLine("Zaposlenik: " + zaposlenik.Ime + "" + zaposlenik.Prezime);
            Console.WriteLine("Neto: " + zaposlenik.NetoIzracunPlace());
            Console.WriteLine("Porez: " + zaposlenik.Porez);
            Console.WriteLine("Bruto: " + zaposlenik.BrutoIzracunPlace());
        }

        private static void UnesiVrijednostBoda(Zaposlenik zaposlenik)
        {
            throw new NotImplementedException();
        }

        private static void UnesiBodove(Zaposlenik zaposlenik)
        {
            // Korisnik mora ispravno unijeti broj bodova
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite broj bodova: ");

                try
                {
                    zaposlenik.BrojBodova = double.Parse(Console.ReadLine());
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
        }
    }
}
