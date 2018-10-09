using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreiNPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabila = nume pentru o locatie de memorie
            int a;


            string line;

            Console.WriteLine("Introduceti un numar: ");
            line = Console.ReadLine();
            a = int.Parse(line);


            while (a != 1)
            {
                if(a % 2 == 1)
                    a = 3 * a + 1;
                else
                    a = a / 2;
                Console.Write("{0} ", a);
            }

            Console.WriteLine();


        }
    }
}
