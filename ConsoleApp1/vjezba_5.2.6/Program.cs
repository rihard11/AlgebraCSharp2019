using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 5 == 0 || broj % 3 == 0)
            {
                Console.WriteLine("Broj je dobar");
            }
            else
            {
                Console.WriteLine("Broj nije dobar");
            }
            Console.ReadKey();
        }
    }
}
