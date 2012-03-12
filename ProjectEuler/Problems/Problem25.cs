/*
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler.Problems
{
    //I used Eric Lipperts Memoization method from here: http://stackoverflow.com/a/2201064/368070
    public static class ExtensionUtil_func
    {//this is for a Func<long,long>
        public static Func<A1, R> Memoize<A1, R>(this Func<A1, R> f)
        {
            // Return a function which is f with caching.
            var dictionary = new Dictionary<string, R>();
            return (A1 a1) =>
            {
                R r;
                string key = a1.ToString();
                if (!dictionary.TryGetValue(key, out r))
                {
                    // not in cache yet
                    r = f(a1);
                    dictionary.Add(key, r);
                }
                return r;
            };
        }
    }
    public class Problem25 : IProblem
    {
        Func<BigInteger, BigInteger> fib = null;
        public void Run()
        {
            fib = (a) =>
                {
                    if (a <= 0)
                    {
                        return 0;
                    }
                    else if (a < 2)
                    {
                        return 1;
                    }
                    return fib(a - 1) + fib(a - 2);
                };
            fib = fib.Memoize();
            for (long i = 1; i < long.MaxValue; i++)
            {
                BigInteger f = fib(new BigInteger(i));
                if (f.ToString().Length == 1000)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
