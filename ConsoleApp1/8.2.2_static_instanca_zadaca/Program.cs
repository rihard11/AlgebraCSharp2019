using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2_static_instanca_zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (Static_Instanca.Prost(broj))
            {
                Console.WriteLine("Broj je prost.");
            }
            else
            {
                Console.WriteLine("Broj NIJE prost.");
            }

            Static_Instanca SI = new Static_Instanca();
            if (SI.Savrsen(broj))
            {
                Console.WriteLine("Broj je savršen");
            }
            else
            {
                Console.WriteLine("Broj NIJE savršen");
            }

            Console.ReadKey();
        }
    }
}
