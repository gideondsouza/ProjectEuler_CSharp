/*
 If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem1 : IProblem
    {
        public void Run()
        {
            int s = 0;
            foreach (var i in Enumerable.Range(1,999))
            {
                if (MultOr5_3(i))
                {
                    s += i;
                }
            }
            Console.WriteLine("Sum of all mutiples of 3 or 5 below 1000 is :" + s);
        }
        bool MultOr5_3(int x)
        {
            if (((x % 3) == 0) ||
                ((x % 5) == 0))
            {
                return true;
            }
            return false;
        }
    }
}
