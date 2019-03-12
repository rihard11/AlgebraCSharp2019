using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_automobil_zadaca
{
    public class Automobil
    {
        public string MarkaAutomobila = "";
        public double KS = 0;
        public double osnovnaCijena = 0;

        public double IznosPoreza()
        {
            double postotak = 0;

            if (KS < 50)
            {
                postotak = 0.05;
            }
            else if (KS > 50 && KS < 150)
            {
                postotak = 0.1;
            }
            else
            {
                postotak = 0.15;
            }
            return osnovnaCijena * postotak;
        }

        public double UkupnaCijena()
        {
            return osnovnaCijena + IznosPoreza();
        }
    }
}
