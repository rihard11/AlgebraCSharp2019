using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            try
            {
                if (broj % 4 == 0 && broj >= 100)
                {
                    Console.WriteLine("Broj je dobar!");
                }
                else
                {
                    Console.WriteLine("Broj nije dobar");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
