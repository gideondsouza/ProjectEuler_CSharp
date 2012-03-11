/*
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    static class ExtensionUtil_long
    {//learned about this method from here http://stackoverflow.com/a/5793356/368070
        public static int[] Divisors(this int n)
        {
            primes = new List<int>();
            Factors(n);
            if (primes.Count == 0) return new int[0];//NOTE: this is to prevent 0 from getting a factor 1;
            var all_primes = primes.Select((x, y) => new { x, y }).ToList(); //assuming that primes contains duplicates.
            var power_set_primes = GetPowerSet(all_primes);
            var factors = new HashSet<int>();

            foreach (var p in power_set_primes)
            {
                //Console.WriteLine("-"); ////Just to figure out whats going on
                //p.ToList().ForEach(x => Console.WriteLine("[{0},{1}]", x.x, x.y));
                //Console.WriteLine("-");
                var factor = p.Select(x => x.x).Aggregate(1, (x, y) => (x * y));
                if (factor == n) break;
                factors.Add(factor);
            }
            return factors.ToArray();
        }
        static List<int> primes = new List<int>();
        static void Factors(int n)
        {
            if (n <= 1) return;
            if (IsPrime(n))
            {
                primes.Add(n);//we're done now since this is a prime number we don't need to check for factors again, we know this is another factor by 1
                return;
            }
            for (int d = 2; d <= (n - 1); d++)
            {
                if (n % d == 0)
                {
                    primes.Add(d);
                    Factors(n / d);
                    break;
                }
            }
        }
        static bool IsPrime(long n)
        {
            int c = 0;
            for (long i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                    if (c > 1) { return false; }//short-circuit.. we knw its not prime
                }
            }
            if (c == 1)
            {
                return true;
            }
            return false;
        }
        public static IEnumerable<IEnumerable<T>> GetPowerSet<T>(List<T> list)
        {
            return from m in Enumerable.Range(0, 1 << list.Count)
                   select
                       from i in Enumerable.Range(0, list.Count)
                       where (m & (1 << i)) != 0
                       select list[i];
        }
    }
    class Problem21 : IProblem
    {

        public void Run()
        {

            int s = 0;
             s.Divisors();
            //bool[] am = new bool[10000];
            //for (int i = 0; i < 10000; i++)
            //{
            //    var is_a = IsAmicable(i);
            //    if (is_a.Item1)
            //    {
            //        s += i;
            //    }
            //}
            
            Console.WriteLine(s);
        }
        //some linq-iness
        int DivisorSum(int[] dv)
        {
            if (dv.Length == 0) return 0;
            return dv.Aggregate((a, b) => (a + b));
        }
        Tuple<bool, int> IsAmicable(int a)
        {
            int b = DivisorSum(a.Divisors());
            int a_t = DivisorSum(b.Divisors());
            if (a != b && a == a_t)
            {
                return Tuple.Create(true, b);
            }
            return Tuple.Create(false, 0);
        }
    }
}
