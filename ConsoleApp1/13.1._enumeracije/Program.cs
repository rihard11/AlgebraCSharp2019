using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1._enumeracije
{
    public enum RadniDani
    {
        Ponedjeljak = 1,
        Utorak,
        Srijeda,
        Četvrtak,
        Petak

    }

    public enum Ocjene
    {
        Nedovoljan = 1,
        Dovoljan,
        Dobar,
        VrloDobar,
        Odlican

    }

    public enum Katovi
    {
        Prizemlje,
        Prvi,
        Drugi,
        Traći,
        Četvrti

    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d. o. o.");
            algebra.Kat = Katovi.Traći;
        }
    }

    class Firma
    {
        private Katovi kat;
        private object naziv;
 

        public Katovi Kat { get => kat; set => kat = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public Firma(string v)
        {
            this.Naziv = v;
        }

    }
}
