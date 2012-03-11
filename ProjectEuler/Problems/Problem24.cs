/*
A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4.
If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:

012   021   102   120   201   210

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
 * http://projecteuler.net/problem=24
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler.Problems
{
    class Problem24 : IProblem
    {//a full explaination of this problem exsits here:
        //http://forum.projecteuler.net/viewtopic.php?f=2&t=2324
        public void Run()
        {
            fact(999999, 9);//first arg is the x-th digit you want. Second is the 9! possibilities
            
            Console.WriteLine(result);
        }
        List<int> nums = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string result = "";
        int len = 10;
        void fact(int n, int i)
        {
            int f = Factorial(i);
            int pos = n / f;
            result += nums[pos].ToString();
            if (result.Length == len) return;
            nums.Remove(nums[pos]);
            fact(n % f, --i);
        }
        private int Factorial(int n)
        {
            int f = 1;
            for (int i = n; i >= 1; i--)
            {
                f = f * i;
            }
            return f;
        }
    }
}
