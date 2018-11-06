using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _611
{
    class Program
    {
        static void Main(string[] args)
        {
            // se citesc numere intregi pana cand se introduce zero. 
            // se cere sa se determine cel mai mare  numar introdus. 

            int maxim;

            // maxim = MaximSecventa();

            //Console.WriteLine("Cel mai mare numar din secventa este: {0}", maxim);


            // se citesc numere intregi pana cand se introduce zero.
            // se cere sa se determine cea mai mare diferenta in 
            // valoare absoluta dintre doua numere consecutive.
            // zeroul final nu face parte din secventa.

            // maxim = MaximDiffSecventa();
            // Console.WriteLine("Cea mai mare diferenta dintre doua numere consecutive este: {0}", maxim);



            // se da un numar n;
            // se cere sa se genereze secventele:
            // 1 1 2 1 2 3 ...
            // 1 2 3 3 4 5 4 5 6 7 ...
            int n;
            n = int.Parse(Console.ReadLine());

            GenSecventa1(n);
            GenSecventa2(n);

            GenSecventa1_2(n);
            GenSecventa2_2(n);


            GenSecventa1_3(n);
            GenSecventa2_3(n);

            // se da un numar k
            // se cere sa se afiseze primiele k elemente ale sirurilor:
            // 1 1 2 1 2 3 ...
            // 1 2 3 3 4 5 4 5 6 7 ...
            int k;
            k = int.Parse(Console.ReadLine());
            GenSecventa1_4(k);
            GenSecventa2_4(k);

        }

        private static void GenSecventa2_4(int k)
        {
            int i, j;

            i = 1; j = 1;

            int total, contor = 0;
            total = k;


            while (contor < total)
            {
                Console.Write("{0} ", j);
                contor++;
                j++;
                if (j > 2 * i - 1)
                {
                    i++;
                    j = i;
                }
            }
            Console.WriteLine();
        }

        private static void GenSecventa1_4(int k)
        {
            int i, j;

            i = 1; j = 1;

            int total, contor = 0;
            total = k;


            while (contor < total)
            {
                Console.Write("{0} ", j);
                contor++;
                j++;
                if (j > i)
                {
                    i++;
                    j = 1;
                }
            }
            Console.WriteLine();
        }

        private static void GenSecventa2_3(int n)
        {
            int i, j;

            i = 1; j = 1;

            int total, contor = 0;
            total = n * (n + 1) / 2;


            while (contor < total)
            {
                Console.Write("{0} ", j);
                contor++;
                j++;
                if (j > 2 * i - 1)
                {
                    i++;
                    j = i;
                }
            }
            Console.WriteLine();
        }

        private static void GenSecventa1_3(int n)
        {
            int i, j;

            i = 1; j = 1;

            int total, contor = 0;
            total = n * (n + 1) / 2;


            while (contor < total)
            {
                Console.Write("{0} ", j);
                contor++;
                j++;
                if (j > i)
                {
                    i++;
                    j = 1;
                }
            }
            Console.WriteLine(); 
        }

        private static void GenSecventa1_2(int n)
        {
            int i, j;
            i = 1;

            while (i <= n)
            {
                j = 1;
                while (j <= i)
                {
                    Console.Write("{0} ", j);
                    j++;
                }
                i++;
            }
            Console.WriteLine();
        }

        private static void GenSecventa2_2(int n)
        {
            int i, j;
            i = 1;

            while (i <= n)
            {
                j = i;
                while (j <= 2 * i - 1)
                {
                    Console.Write("{0} ", j);
                    j++;
                }
                i++;
            }
            Console.WriteLine();
        }

        private static void GenSecventa2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= 2 * i - 1; j++)
                {
                    Console.Write("{0} ", j);
                }
            }
            Console.WriteLine();
        }

        private static void GenSecventa1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
            }
            Console.WriteLine();
        }

        private static int MaximDiffSecventa()
        {
            int maxim = 0;
            bool ret;
            int x, y;
            ret = int.TryParse(Console.ReadLine(), out x);
            if (x == 0)
            {
                return 0;
            }

            do
            {
                ret = int.TryParse(Console.ReadLine(), out y);
                if (ret == false)
                {
                    continue;
                }
                else
                {
                    if (y == 0)
                    {
                        break;
                    }
                    else
                    {
                        int diff = Math.Abs(x - y);
                        if (diff > maxim)
                        {
                            maxim = diff;
                        }
                        x = y;
                    }
                }

            } while (true);


            return maxim;

        }

        private static int MaximSecventa()
        {
            int n = 0;
            int maxim;
            bool ret;

            maxim = int.MinValue;
            do
            {
                ret = int.TryParse(Console.ReadLine(), out n);
                if (ret == true)
                {
                    if (n > maxim)
                    {
                        maxim = n;
                    }
                }
                else
                    n = int.MinValue;
            } while (n != 0);

            return maxim;
        }
    }
}
