using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1610
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            string line;


            Console.WriteLine("Introduceti un numar: ");
            line = Console.ReadLine();

            try
            {
                n = int.Parse(line);
            
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Suma numerelor de la 1 la {0} este {1}", n, Suma(n));
            Console.WriteLine("Suma numerelor de la 1 la {0} este {1}", n, Suma2(n));
        }

        private static int Suma2(int n)
        {
            return n * (n + 1) / 2;
        }

        private static int Suma(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            return s;
        }
    }
}
