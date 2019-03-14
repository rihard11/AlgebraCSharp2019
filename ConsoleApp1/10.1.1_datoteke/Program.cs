using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._1_datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite neki text: ");
            string upis = Console.ReadLine();

            // Kreiranje handle
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);
            // Zapisivanje u datoteku
            StreamWriter sw1 = new StreamWriter(fs1);

            sw1.WriteLine(upis);

            sw1.Flush();

            sw1.Close();
            fs1.Close();

            // Čitanje iz datoteke
            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs2);

            string procitano = sr1.ReadToEnd();
            Console.WriteLine("Ispis iz datoteke Proba.txt");
            Console.WriteLine(procitano);

            Console.ReadKey();
        }
    }
}
