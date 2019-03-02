using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_5._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodni broj: ");
            try
            {
                int broj = int.Parse(Console.ReadLine());

                if (broj <= 0)
                {
                    throw new NegativanBrojException("Broj je negativan. Unesite pozitivan broj");
                }
                if (broj > 10000)
                {
                    throw new PrevelikBrojException("Broj je prevelik. Unesite broj manji od 10000");
                }
                

                int zbrojDjelitelja = 0;

                for (int i = 1; i < broj; i++)
                {
                    if (broj % i == 0)
                    {
                        zbrojDjelitelja += i;
                    }
                }
                if (broj == zbrojDjelitelja)
                {
                    Console.WriteLine("Broj {0} je savrsen", broj);
                }
                else
                {
                    Console.WriteLine("Broj {0} nije savrsen", broj);
                }
            }
            catch (NegativanBrojException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (PrevelikBrojException ex)
            {
                Console.WriteLine("PREVELIK BROJ za ovu operaciju!" + ex.ToString());
            }
            finally
            {
            Console.ReadKey();
            }

        }
    }
    public class NegativanBrojException : Exception
    {
        public NegativanBrojException()
        {
        }

        public NegativanBrojException(string message)
        : base(message)
        {
        }

        public NegativanBrojException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
    public class PrevelikBrojException : Exception
    {
        public PrevelikBrojException()
        {
        }

        public PrevelikBrojException(string message)
        : base(message)
        {
        }

        public PrevelikBrojException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
