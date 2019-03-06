using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4_celzij_u_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite stupnjeve u Celzijusu (°C): ");
            double celzijus = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} °C = {1} °F", celzijus, CtoF(celzijus));
            Console.ReadKey();
        }

        static double CtoF(double celzijus)
        {
            return (celzijus * 9 / 5) + 32;
        }
    }
}
