using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4_zbirka_znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodni broj");
            int broj = int.Parse(Console.ReadLine());

            ArrayList arr = new ArrayList();

            while (broj > 0)
            {
                arr.Add(broj % 10);
                broj /= 10;
            }

            Console.WriteLine("Ispis znamenki naopako: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
