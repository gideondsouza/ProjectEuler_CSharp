/*

 The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

 Find the sum of all the primes below two million.
  http://projecteuler.net/problem=10
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{//A general IsPrime function will take too long. It takes about 22 minutes for the whole program to run
    //I used the Seive of Eratosthenes algorithm which turns out to take ~79 milliseconds! =D
    //http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

    public class Problem10 : IProblem
    {
        public void Run()
        {

            long sum = 0;
            long n = 2000000;
            bool[] e = new bool[n];//by default they're all false
            for (int i = 2; i < n; i++)
            {
                e[i] = true;
            }

            for (int j = 2; j < n; j++)
            {
                if (e[j])//is true
                {
                    for (long p = 2; (p*j) < n; p++)
                    {
                        e[p * j] = false;
                    }
                }
            }
            for (long r = 2; r < n; r++)
            {
                if (e[r])
                {
                    sum += r;
                }
            }
            Console.WriteLine("Sum:" + sum);
        }
    }
}
