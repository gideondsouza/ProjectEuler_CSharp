using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem4 : IProblem
    {
        public void Run()
        {
            //going from 100 to 999  MAKE palindromes with some string conversions
            for (int p = 999; p >= 100; p--)
            {
                //smush into palindrome by string conversion
                string palin = p.ToString() + new string(p.ToString().Reverse().ToArray());
                int pp = Convert.ToInt32(palin);
                if (CheckProd(pp))//check for factors
                {
                    Console.WriteLine(pp);
                    break;
                }
            }
        }
        bool CheckProd(int _p)
        {//starting from 100 find divisors
            for (int i = 100; i <= 999; i++)
            {//and check if they're both 3 digits
                if (_p % i == 0 && 
                    (_p/i).ToString().Length == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
