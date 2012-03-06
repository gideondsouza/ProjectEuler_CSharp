/*

 By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 What is the 10 001st prime number?
 *
 * http://projecteuler.net/problem=7
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem7 : IProblem
    {
        public void Run()
        {
            int c = 0;
            long answer = 0;
            for (long i = 1; i < long.MaxValue; i++)
            {
                if (IsPrime(i))
                {
                    c++;
                }
                if (c == 10001)
                {
                    answer = i;
                    break;
                }
            }
            Console.WriteLine(answer);
        }
        //same isPrime from Prob3, I want each problem to be unitized
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
