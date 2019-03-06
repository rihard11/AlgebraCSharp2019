using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._4_celzij_u_fahrenheit_obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite stupnjeve u Fahrenheitu (°F): ");
            double fahren = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} °F = {1} °C", fahren, FtoC(fahren));
            Console.ReadKey();
        }

        static double FtoC(double fahren)
        {
            return Math.Round((fahren -32) * 5/9, 2);
        }
    }
}
