using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_za_11._03._19
{
    class Ucenik
    {
        private string ime;
        public string Ime { get => ime; }

        private string prezime;
        public string Prezime { get => prezime; }

        private long oib;
        public long Oib { set => oib = value; }

        public int telefon;

        private int racun;
        public int Racun { get => racun; set => racun = value; }

        Random rand = new Random();


        public override string ToString()
        {
            return "Pozdrav "
                + this.Ime + " "
                + this.Prezime + ", stanje tvog racuna je "
                + this.Racun + " kuna.";
        }


        public Ucenik() { }

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.racun = rand.Next(2000, 6001);
        }

        public Ucenik(string ime, string prezime, int oib)
            : this(ime, prezime)
        {
            this.Oib = oib;
            this.racun = rand.Next(2000, 6001);
        }



        public Ucenik(string ime, string prezime, int oib, int racun)
            : this(ime, prezime, oib)
        {
            this.Racun = racun;
        }

    }
}
