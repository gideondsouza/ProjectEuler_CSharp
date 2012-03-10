/*
 * How many routes are there through a 2020 grid?
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{//this is a simple math problem where the answer is C(40,20) or 40C20 where C is combinations.
    //so its <paths_needed>C<rows_avialable>

    //Brute forcing the solution for a 20X20 grid takes a LONG time. We need to cache paths that we've taken already.
    //I used Eric Lipperts Memoization method from here: http://stackoverflow.com/a/2201064/368070
    public static class ExtensionUtil
    {
        public static Func<A1, A2, R> Memoize<A1, A2, R>(this Func<A1, A2, R> f)
        {
            // Return a function which is f with caching.
            var dictionary = new Dictionary<string, R>();
            return (A1 a1, A2 a2) =>
            {
                R r;
                string key = a1 + "x" + a2;
                if (!dictionary.TryGetValue(key, out r))
                {
                    // not in cache yet
                    r = f(a1, a2);
                    dictionary.Add(key, r);
                }
                return r;
            };
        }
    }
    class Problem15 : IProblem
    {
        int lmt = 20;
        public void Run()
        {
            Func<int, int, long> move = null;
            move = (int right, int down) =>
            {
                long cnt = 0;
                if (right == lmt || down == lmt)
                {
                    return 1;
                }
                cnt += move(right + 1, down);
                cnt += move(right, down + 1);
                return cnt;
            };
            move = move.Memoize();
            //Func<int, int, long> f = move;
            //Func<int, int, long> m = f.Memoize();
            Console.WriteLine(move(0, 0));
        }
    }
}
