using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_zbirka_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);

            FileStream fs2 = new FileStream("3or7saZarezom.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);

            Console.WriteLine("Unesite neki broj: ");
            int broj = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 1000; i++)
            {
                if (broj % 3 == 0 || broj % 7 == 0)
                {
                    sw1.WriteLine(i);
                    sw2.WriteLine("{0}, ", i);
                }

            }

            sw1.Flush();
            sw1.Close();
            sw2.Flush();
            sw2.Close();
            fs1.Close();
            fs2.Close();

            Console.WriteLine("Želite li ispisati sadržaj datoteka: (D/N)");
            char odgovor = Console.ReadKey().KeyChar;

            if (odgovor == 'd' || odgovor == 'D')
            {
                fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
                StreamReader sr1 = new StreamReader(fs1);
                string s = sr1.ReadToEnd();
                Console.WriteLine(s);
                sr1.Close();
                fs1.Close();
            }

            Console.ReadKey();
        }
    }
}
