using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Unesite broj: ");
            //int a = int.Parse(Console.ReadLine());

            //long fakt = 1;

            //for (int i = 1; i <= a; i++)
            //{
            //    fakt *= i;
            //}
            //Console.WriteLine("{0}! = {1}", a, fakt);
            //Console.ReadKey();   

            Console.Write("Unesite broj: ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    throw new NegativeNumberException("Negativni broj. Unesite pozitivni broj");
                }
                if (a >= 20)
                {
                    throw new VeciOdDvajstException("Broj je prevelik, rezultat je veći ok dimenzije 'int' 2.147.483.647");
                }

                int fact = 1;
                for (int i = a; i > 0; i--)
                {
                    //Console.WriteLine(i);
                    fact *= i;
                }
                Console.WriteLine(fact);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Negativni broj" + ex.ToString());
            }
            catch (VeciOdDvajstException ex)
            {
                Console.WriteLine("Dozvoljeni brojevi su u intervalu 1 do 19" + ex.ToString());
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
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message)
        : base(message)
        {
            Console.WriteLine("Dodatno custom pojašnjenje klase NegativNumberException");
        }

        public NegativeNumberException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
    public class VeciOdDvajstException : Exception
    {
        public VeciOdDvajstException()
        {
        }

        public VeciOdDvajstException(string message)
        : base(message)
        {
        }

        public VeciOdDvajstException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

