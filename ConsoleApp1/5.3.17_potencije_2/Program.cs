using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._17_potencije_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int potencija;

            for (int i = 0; i <= 10; i++)
            {
                potencija = 1;

                for (int j = 1; j <= i; j++)
                {
                    potencija *= 2;
                }
            Console.WriteLine("2 na {0} = {1}", i, potencija);
            }
            Console.ReadKey();
        }
    }
}
