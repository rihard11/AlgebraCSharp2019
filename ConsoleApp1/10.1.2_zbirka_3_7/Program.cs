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
        //static void Main(string[] args)
        //{
        //    FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
        //    StreamWriter sw1 = new StreamWriter(fs1);

        //    FileStream fs2 = new FileStream("3or7saZarezom.txt", FileMode.Create);
        //    StreamWriter sw2 = new StreamWriter(fs2);

        //    Console.WriteLine("Unesite neki broj: ");
        //    int broj = int.Parse(Console.ReadLine());

        //    for (int i = 1; i <= 1000; i++)
        //    {
        //        if (broj % 3 == 0 || broj % 7 == 0)
        //        {
        //            sw1.WriteLine(i);
        //            sw2.WriteLine("{0}, ", i);
        //        }

        //    }

        //    sw1.Flush();
        //    sw1.Close();
        //    sw2.Flush();
        //    sw2.Close();
        //    fs1.Close();
        //    fs2.Close();

        //    Console.WriteLine("Želite li ispisati sadržaj datoteka: (D/N)");
        //    char odgovor = Console.ReadKey().KeyChar;

        //    if (odgovor == 'd' || odgovor == 'D')
        //    {
        //        fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
        //        StreamReader sr1 = new StreamReader(fs1);
        //        string s = sr1.ReadToEnd();
        //        Console.WriteLine(s);
        //        sr1.Close();
        //        fs1.Close();
        //    }

        //    Console.ReadKey();


        class PrintString
        {
            static FileStream fs;
            static StreamWriter sw;

            // delegate declaration
            public delegate void printString(string s);

            // this method prints to the console
            public static void WriteToFileNoviRed(string s)
            {
                string[] red = s.Split(',');

                fs = new FileStream("3or7uNoviRed.txt",
                FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (var item in red)
                {
                    sw.WriteLine(item);
                }


                sw.Flush();
                sw.Close();
                fs.Close();
            }

            //this method prints to a file
            public static void WriteToFileZarez(string s)
            {
                fs = new FileStream("3or7Zarez.txt",
                FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            // this method takes the delegate as parameter and uses it to
            // call the methods as required
            public static void sendString(printString ps)
            {
                string trisedam = "";
                for (int i = 0; i < 100; i++)
                {
                    if (i % 3 == 0 || i % 7 == 0)
                    {
                        trisedam += i + ",";
                    }
                }
                ps(trisedam);
            }
            static void Main(string[] args)
            {
                printString ps1 = new printString(WriteToFileZarez);
                printString ps2 = new printString(WriteToFileNoviRed);
                sendString(ps1);
                sendString(ps2);
                Console.ReadKey();
            }
        }
    }
}
