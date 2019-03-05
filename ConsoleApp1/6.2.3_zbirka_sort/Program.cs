using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3_zbirka_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaBrojeva = new List<int>();
            int broj = -1;

            Console.WriteLine("Unesite brojeve, za kraj unesite 0");

            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                listaBrojeva.Add(broj);
            }
            listaBrojeva.Sort();

            Console.WriteLine("Ispis:");
            foreach (int item in listaBrojeva)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
