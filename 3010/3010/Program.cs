using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace _3010
{
    class Program
    {
        #region Game
        static void Game()
        {
            int stake = 50;
            int goal = 100;
            int times = 10000;
            int bets = 0;
            int sum = 0;
            Random rnd = new Random();

            int wins = 0, looses = 0;
            for (int i = 0; i < times; i++)
            {
                bets = 0;
                stake = 50;
                while (stake < goal && stake > 0)
                {
                    if (rnd.Next(2) == 0)
                    {
                        stake--;
                    }
                    else
                    {
                        stake++;
                    }
                    bets++;
                }
                sum += bets;
                if (stake == 0)
                {
                    looses++;
                }
                else
                {
                    wins++;
                }
            }
            Console.WriteLine("Wins: {0}, Looses: {1}, Average Bets: {2}", wins, looses, sum / times);
        }
        #endregion
        static void Main(string[] args)
        {
            // Determinarea numarului de divizori ai unui numar natural
            // Determinarea sumei divizorilor unui numar natural;

            ulong n;

            string line;
            line = Console.ReadLine();

            n = uint.Parse(line);

            //Console.WriteLine("Numarul de divizori este: {0}", NumarDivizori2(n));
            //Console.WriteLine("Suma divizorilor este: {0}", SumaDivizori(n));

            Console.WriteLine("Numarul de divizori este: {0}", NumarDivizoriFast(n));
            //Console.WriteLine("Suma divizorilor este: {0}", SumaDivizoriFast(n));
        }

        private static ulong NumarDivizoriFast(ulong n)
        {
            ulong p = 1;
            ulong d = 2;
            ulong a = 0;
            while (n > 1)
            {
                a = 0;
                while (n % d == 0)
                {
                    a++;
                    n = n / d;
                }
                p = p * (a + 1);
                d++;
            }
            return p;
        }

        private static ulong SumaDivizori(ulong n)
        {
            ulong suma = 0;

            suma = n;
            for (ulong d = 1; d <= n / 2; d++)
            {
                if (n % d == 0)
                {
                    suma += d;
                }
            }
            return suma;
        }

        private static ulong NumarDivizori(ulong n)
        {
            ulong contor = 1;
            if (n == 1)
            {
                return 1;
            }
            for (ulong d = 1; d <= n / 2; d++)
            {
                if (n % d == 0)
                {
                    contor++;
                }
            }
            return contor;
        }
        private static ulong NumarDivizori2(ulong n)
        {
            ulong contor = 2;

            if (n == 1)
            {
                return 1;
            }
            ulong d;
            for (d = 2;  d * d < n; d++)
            {
                if (n % d == 0)
                {
                    contor += 2;
                }
            }
            if (d * d == n )
            {
                contor++;
            }
            return contor;
        }
    }
}
