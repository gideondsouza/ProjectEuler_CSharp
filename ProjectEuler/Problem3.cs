using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem3 : IProblem
    {
        public void Run()
        {
            Console.WriteLine("Ze prime factors are");
            Factors(limit);
            foreach (var f in factors.Distinct())
            {
                if (IsPrime(f))
                {
                    Console.WriteLine("IsPrime:" + f);
                }
            }
        }
        long limit = 600851475143;

        List<long> factors = new List<long>();
        void Factors(long n)
        {
            if (n <= 1) return;
            if (IsPrime(n))
            {
                factors.Add(n);//we're done now since this is a prime number we don't need to check for factors again, we know this is another factor by 1
                return;
            }
            for (long d = 2; d <= (n - 1); d++)
            {
                if (n % d == 0)
                {
                    factors.Add(d);
                    Factors(n / d);
                    break;
                }
            }
        }
        bool IsPrime(long n)
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
    }
}
