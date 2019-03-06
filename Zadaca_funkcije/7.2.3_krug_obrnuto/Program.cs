using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3_krug_obrnuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite povrsinu kruga: ");
            double povrsina = double.Parse(Console.ReadLine());
            Console.WriteLine("Opseg kruga s povrsinom {0} je {1}", povrsina, OpsegKruga(povrsina));
            Console.WriteLine("Radijus kruga s povrsinom {0} je {1}", povrsina, RadijusKruga(povrsina));
            Console.ReadKey();
        }

        static double OpsegKruga(double povrsina)
        {
            return Math.Round(Math.Sqrt(povrsina / Math.PI) * (Math.PI * 2), 2);
        }

        static double RadijusKruga(double povrsina)
        {
            return Math.Round(Math.Sqrt(povrsina / Math.PI));
        }
    }
}
