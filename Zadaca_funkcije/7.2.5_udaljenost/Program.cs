using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._5_udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite x koordinatu točke P1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y koordinatu točke P1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite x koordinatu točke P2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y koordinatu točke P2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("d(P1, P2) = {0}", d(x1, y1, x2, y2));
            Console.ReadKey();

        }

        static double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }
    }
}
