using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4_drugi_nacij
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulaz_broj = Console.ReadLine();
            int broj = int.Parse(ulaz_broj);
            Console.WriteLine("Originel: {0} obrnuti {1}", broj, new string(ulaz_broj.Reverse().ToArray()));

            Console.ReadKey();
        }
    }
}
