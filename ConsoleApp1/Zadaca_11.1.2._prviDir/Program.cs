using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_11._1._2._prviDir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite putanju: ");

            string putanja = Console.ReadLine();

            if (!Directory.Exists(putanja))
            {
                Console.WriteLine("Navedena putanja ne postoji.");
            }
            else
            {
                string dir = (from di in Directory.GetDirectories(putanja)
                              orderby Path.GetDirectoryName(di) descending
                              select di).FirstOrDefault();
                if (!string.IsNullOrEmpty(dir))
                {
                    Console.WriteLine("Pronađeni direktorij: " + Path.GetFileName(dir));
                }
                else
                {
                    Console.WriteLine("Nije pronađen niti jedan direktorij.");
                }
            }
            Console.ReadKey();
        }
    }
}
