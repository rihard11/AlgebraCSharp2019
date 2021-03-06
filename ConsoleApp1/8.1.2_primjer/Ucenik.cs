﻿using System;

namespace _8._1._2_primjer
{
    internal class Ucenik
    {
        private string ime = "";
        public DateTime datumNastanka;
        public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;

        public string Ime { get => ime; set => ime = ToUpper.FirstCharToUpper(value); }

        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
        }

        public Ucenik(string v)
        {
            this.ime = v;
        }

        public Ucenik(string v, string prez)
        {
            this.ime = v;
            this.prezime = prez;
        }

        internal double Prosjek()
        {
            double prosjek = 0;
            prosjek = (ocjenaIzBiologije + ocjenaIzEngleskog + ocjenaIzMatematike) / 3;

            return prosjek;
        }

        public override string ToString()
        {
            return "Moje ime je " + this.ime + " a moj prosjek je: " + this.Prosjek();
        }

    }
}