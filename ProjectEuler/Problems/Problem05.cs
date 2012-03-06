/*
 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 * http://projecteuler.net/problem=5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{//uses brute force and takes some time. 
    //The alternate and more generic solution here is LCM(1,20) which is what the problem is really.
    class Problem5 : IProblem
    {
        public void Run()
        {
            for (int i = 21; i < int.MaxValue; i++)//yep the value is under int.Max =D
            {//optimize. Go from 21
                if (DiviTill(i,20))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        bool DiviTill(int target, int limit)//limit is 20, like check divisibility from 1 to 20
        {
            bool flag = true;
            for (int i = 2; i <= limit; i++)//skip 1
            {
                if (target % i != 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
