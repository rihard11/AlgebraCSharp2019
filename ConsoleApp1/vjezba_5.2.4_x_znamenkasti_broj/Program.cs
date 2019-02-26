using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._4_x_znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                a = -a;
            }

            if (a < 10)
            {
                Console.WriteLine("Broj je jednoznamenkast");
            }
            else if (a < 100)
            {
                Console.WriteLine("Broj je dvoznamenkast");
            }
            else if (a  < 1000)
            {
                Console.WriteLine("Broje je troznamenkast");
            }
            else
            {
                Console.WriteLine("Broj je višeznamenkast");
            }
            Console.ReadLine();
        }
    }
}
