/*
The sum of the squares of the first ten natural numbers is,  1^2 + 2^2 + ... + 10^2 = 385
 * 
The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)2 = 552 = 3025
 * 
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 * http://projecteuler.net/problem=6
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    class Problem6 : IProblem
    {//extremely simple one. However this falls into understand summation of series better I think
        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                sqsum += (i * i);
            }
            Console.WriteLine(((sum * sum) - sqsum));
        }
        int sum = 0;
        int sqsum = 0;
    }
}
