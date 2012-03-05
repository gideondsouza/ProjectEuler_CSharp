/*
A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
 
 * 
 * http://projecteuler.net/problem=9
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem9 : IProblem
    {
        public void Run()
        {
            //A much better solution based on math:http://en.wikipedia.org/wiki/Pythagorean_triple

            for (int m = 0; m <= 1000; m++)
            {
                for (int n = 0; n <= 1000; n++)
                {
                    int mm = m * m;
                    int nn = n * n;
                    int a = (mm - nn), b = (2 * m * n), c = (mm + nn);
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine("a:{0} b:{1} c:{2} Product:{3}", a, b, c, a * b * c);
                    }
                }
            }

            //My initial brute force method : (Also needs a perfect square method)
            //for (int a = 0; a <= 1000; a++)
            //{
            //    for (int b = 0; b <= 1000; b++)
            //    {
            //        int c = (a * a) + (b * b);
            //        if (IsPerfectSquare(c))
            //        {
            //            if (a + b + Math.Sqrt(c) == 1000)
            //            {
            //                Console.WriteLine("a:{0} b:{1} c:{2} Product:{3}", a, b, Math.Sqrt(c), a * b * Math.Sqrt(c));
            //            }
            //        }
            //    }
            //}
        }
        bool IsPerfectSquare(long input)
        {//plagiarized from http://stackoverflow.com/a/343862/368070
            double root = Math.Sqrt(input);

            long rootBits = BitConverter.DoubleToInt64Bits(root);
            long lowerBound = (long)BitConverter.Int64BitsToDouble(rootBits - 1);
            long upperBound = (long)BitConverter.Int64BitsToDouble(rootBits + 1);

            for (long candidate = lowerBound; candidate <= upperBound; candidate++)
            {
                if (candidate * candidate == input)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
