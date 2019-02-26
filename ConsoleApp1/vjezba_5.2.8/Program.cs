using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_5._2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite godinu: ");
            int godina = int.Parse(Console.ReadLine());

            if ((godina % 4 == 0 && (!(godina % 100 == 0))) || (godina % 400 == 0))
            {
                Console.WriteLine("Godina je prijestupna");
            } else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
            Console.ReadKey();
        }
    }
}
