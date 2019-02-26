using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._2._4._3_seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("unesite ime škole koju pohađate: ");
            string skola = Console.ReadLine();

            if (skola != "Algebra")
            {
                Console.WriteLine("Upišite informatički seminar u Algebri!");
            }
            else
            {
                Console.WriteLine("Bravo!");
            }
            Console.ReadKey();
        }
    }
}
