/*
 * What is the sum of the digits of the number 2^1000?
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler.Problems
{
    class Problem16 : IProblem
    {//quite a fairly simple problem :)
        public void Run()
        {
            double p = Math.Pow(2, 1000);
            BigInteger num = new BigInteger(p);
            int sum = 0;
            foreach (var digit in num.ToString())
            {
                 sum += int.Parse(digit.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
