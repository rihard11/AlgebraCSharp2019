using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvršava naš program: ");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.WriteLine("Postoji li Proba.txt u izvršnoj mapi: ");
            // Path clasa
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            Console.WriteLine(File.Exists(mojaPutanja));

            if (!Directory.Exists("Proba"))
            {
                Directory.CreateDirectory("Proba");
            }

            Console.WriteLine("Direktoriji na C: ");
            string[] sDirs = Directory.GetDirectories(@"C:\");
            foreach (var sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            Console.WriteLine("Datoteke na C: ");
            string[] sFiles = Directory.GetFiles(@"C:\");
            foreach (var sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
            Console.ReadKey();
        }
    }
}
