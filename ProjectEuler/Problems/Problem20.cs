/*
 * Find the sum of the digits in the number 100!
 * http://projecteuler.net/problem=20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler.Problems
{
    class Problem20 : IProblem
    {
        public void Run()
        {
            string num = Factorial(100).ToString();
            int s = 0;
            foreach (var digit in num)
            {
                s += int.Parse(digit.ToString());
            }
            Console.WriteLine(s);
        }
        private BigInteger Factorial(int n)
        {
            BigInteger f = 1;
            for (int i = n; i >= 1; i--)
            {
                f = f * i;
            }
            return f;
        }
    }
}
