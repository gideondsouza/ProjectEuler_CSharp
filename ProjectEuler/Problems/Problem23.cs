/*
 A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper 
 divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be 
written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater 
than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis 
even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
 
 * http://projecteuler.net/problem=23
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    class Problem23 : IProblem
    {//We approach this problem with a seive again
        public void Run()
        {
            const int LEN = 28123;
            int s = 0;
            //bool[] ab = new bool[LEN];
            List<int> ab = new List<int>();
            bool[] target = new bool[LEN];
            for (int i = 0; i < LEN; i++)
            {
                if (IsAbundant(i))
                {
                    ab.Add(i);
                }
            }
            for (int j = 0; j < ab.Count; j++)
            {
                for (int k = 0; k < ab.Count; k++)
                {
                    if (ab[j] + ab[k] < LEN)
                    {
                        target[ab[j] + ab[k]] = true;//bc all elements are default false
                    }
                }
            }
            for (int a = 0; a < LEN; a++)
            {
                if (!target[a])//search for falses
                {
                    s += a;
                }
            }
            Console.WriteLine(s);
        }
        bool IsAbundant(int n)
        {
            int d = DivisorSum(n.Divisors());
            if (d > n)
            {
                return true;
            }
            return false;
        }
        int DivisorSum(int[] dv)
        {
            if (dv.Length == 0) return 0;
            return dv.Aggregate((a, b) => (a + b));
        }
    }
}
