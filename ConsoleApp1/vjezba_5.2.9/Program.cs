using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }

            if (broj % 3 == 0)
            {
                Console.WriteLine("Broj je djeljiv s 3");
            }
            else
            {
                Console.WriteLine("Ostatak pri djeljenu s 3: {0}", broj % 3);
            }
            Console.ReadKey();
        }
    }
}
