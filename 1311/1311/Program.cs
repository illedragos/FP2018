using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1311
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vectori (tablouri unidimensionale)

            int n, k, i;

            int[] v;

            v = new int[100000];


            for (i = 0; i < v.Length; i++)
            {
                v[i] = i;
            }

            Print(v);

            Shuffle(v);




            Print(v);



            Array.Sort(v);

            //MySort(v);

            //MySort2(v);
            Print(v);

            



        }

        private static void MySort2(int[] v)
        {
            int aux;
            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }

        private static void MySort(int[] v)
        {
            int aux;
            bool sortat;


            do
            {
                sortat = true;
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        sortat = false;
                    }
                }
            } while (! sortat);
            
        }

        private static void Shuffle(int[] v)
        {
            //            --To shuffle an array a of n elements(indices 0..n - 1):
            //for i from n−1 downto 1 do
            //                    j ← random integer such that 0 ≤ j ≤ i
            //                    exchange a[j] and a[i]
            int j, aux;
            Random rnd = new Random();
            for (int i = v.Length  - 1; i > 0; i--)
            {
                j = rnd.Next(i + 1);
                aux = v[i];
                v[i] = v[j];
                v[j] = aux;
            }
        }

        private static void Print(int[] v)
        {
            int i;
            for (i = 0; i < v.Length; i++)
            {
                Console.Write("{0} ", v[i]);
            }

            Console.WriteLine();
         }
    }
}
