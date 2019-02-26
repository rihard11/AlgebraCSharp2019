using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._5_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj >= 100 && broj <= 200)
            {
                Console.WriteLine("Broj je u intervalu");
            }
            else
            {
                Console.WriteLine("Broj nije u intervalu!");
            }
            Console.ReadKey();
        }
    }
}
