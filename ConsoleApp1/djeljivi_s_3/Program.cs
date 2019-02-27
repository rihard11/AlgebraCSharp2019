using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djeljivi_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesi 1. broj ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesi 2. broj ");
                int b = int.Parse(Console.ReadLine());

                if (b < a)
                {
                    throw new Exception("Nepravilan interval");
                }

                for (int i = a; i <= b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
