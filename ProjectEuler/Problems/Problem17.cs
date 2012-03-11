/*
 * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
 * http://projecteuler.net/problem=17
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public static class ExtensionUtil_str
    {
        public static string ToWords(this int v)
        {//shamelessly got this code from this post here: http://stackoverflow.com/a/408776/368070
            //its code golf indeed
            if (v == 0) return "zero";
            var units = " one two three four five six seven eight nine".Split();
            var teens = " eleven twelve thir# four# fif# six# seven# eigh# nine#".Replace("#", "teen").Split();
            var tens = " ten twenty thirty forty fifty sixty seventy eighty ninety".Split();
            var thou = " thousand m# b# tr# quadr# quint# sext# sept# oct#".Replace("#", "illion").Split();
            var g = (v < 0) ? "minus " : "";
            var w = "";
            var p = 0;
            v = Math.Abs(v);
            while (v > 0)
            {
                int b = (int)(v % 1000);
                if (b > 0)
                {
                    var h = (b / 100);
                    var t = (b - h * 100) / 10;
                    var u = (b - h * 100 - t * 10);
                    var s = ((h > 0) ? units[h] + " hundred" + ((t > 0 | u > 0) ? " and " : "") : "")
                          + ((t > 0) ? (t == 1 && u > 0) ? teens[u] : tens[t] + ((u > 0) ? " " : "") : "")
                          + ((t != 1) ? units[u] : "");
                    s = (((v > 1000) && (h == 0) && (p == 0)) ? " and " : (v > 1000) ? ", " : "") + s;
                    w = s + " " + thou[p] + w;
                }
                v = v / 1000;
                p++;
            }
            return g + w;
        }
    }
    class Problem17 : IProblem
    {
        public void Run()
        {
            StringBuilder strb = new StringBuilder();
            for (int i = 1; i <= 1000; i++)
            {
                strb.Append(i.ToWords().Replace(" ", ""));
            }
            Console.WriteLine(strb.Length);

        }
    }
}
