using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._2_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Učitavamo datumski podatak
            Console.WriteLine("Unesite podatak tipa DateTima: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            // Ispisujemo datume
            Console.WriteLine("Datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            // Ispisujemo vrijeme
            Console.WriteLine("Vrijeme: ");
            Console.WriteLine(d1.ToShortTimeString());

            // Ispis dana u tjednu
            Console.WriteLine("Dan u tjednu: ");
            // Ako ne kastamo ispisuje se slovima
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            // Sistemsko vrijeme na tisućinku sekunde
            Console.WriteLine("Sada je točno: ");
            d1 = DateTime.Now;

            Console.WriteLine("MMMM, dddd yyyyy HH mm:ss fff");

            Console.WriteLine("Koliko ime do nove godine: ");
            DateTime dNG = new DateTime(2010, 1, 1);

            TimeSpan ts = dNG.Subtract(d1);
        }
    }
}
