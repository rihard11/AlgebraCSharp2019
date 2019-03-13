using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5._1_eventi
{
    public class Osoba
    {
        // Deklariranje događaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        // Svojstva
        private string ime;
        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }
    }
}
