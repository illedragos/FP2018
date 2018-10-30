using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310
{
    class Program
    {
        static void Main(string[] args)
        {
            // *******************
            // nu toate numerele reale sunt reprezenabile exact pe float / double
            double eps = 0.001;

            double suma = 0.0;

            for (int i = 1; i <= 1000000; i++)
            {
                suma = suma + eps;
            }
            Console.WriteLine(suma);

            // ****************


            // calculam numarul de zile dintre 2 date calendaristice

            int z1 = 23, l1 = 10, a1 = 2018;
            int z2 = 14, l2 = 9, a2 = 1999;


            int diff = 0;



            // calcul...


            while (z1 != z2 || l1 != l2 || a1 != a2)
            {
                diff++;
                // schimb prima data calend cu data zilei anterioare
                if (z1 > 1)
                {
                    z1--;
                }
                else
                {
                    switch (l1)
                    {
                        case 1:
                            z1 = 31;
                            l1 = 12;
                            a1--;
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                        case 9:
                        case 11:
                            z1 = 31;
                            l1--;
                            break;
                        case 5:
                        case 7:
                        case 10:
                        case 12:
                            z1 = 30;
                            l1--;
                            break;
                        case 3:
                            if ((a1 % 4 == 0 && a1 % 100 != 0) || (a1 % 400 == 0))
                                z1 = 29;
                            else
                                z1 = 28;
                            l1 = 2;
                            break;
                        default:
                            break;
                    }
                }
            }




            Console.WriteLine("Numarul de zile dintre cele doua date calendaristice este: {0}", diff);


            DateTime d1 = new DateTime(2018, 10, 23);
            DateTime d2 = new DateTime(1999, 9, 14);
            TimeSpan difts = d1.Subtract(d2);
            Console.WriteLine(difts.TotalDays);



            // random
            Random rnd = new Random();
            int t0 = 0, t1 = 1;
            int v;
            for (int i = 0; i < 100; i++)
            {
                v = rnd.Next(2);
                if (v == 0)
                {
                    t0++;
                }
                else
                {
                    t1++;
                }
            }

            Console.WriteLine("t0 = {0}, t1 = {1}", t0, t1);

        }
    }
}
