/*
 * Find the maximum total from top to bottom of the triangle below:
 * http://projecteuler.net/problem=18
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Triangle
    {
        //this ctor just loads the input into ours Rows field
        public Triangle(string input)
        {
            Rows = new List<int[]>();
            foreach (var line in input.Split('\n'))
            {
                if (line == string.Empty) return;
                List<int> aline = new List<int>();
                foreach (var item in line.Split(' '))
                {
                    aline.Add(Convert.ToInt32(item));
                }
                Rows.Add(aline.ToArray());
            }
        }
        public List<int[]> Rows { get; set; }

        //works its way from the bottom adding up the greatest number to its adjacent upper number
        //--------- Example so out of 8 vs 5 8 is greater. Now replace 2 with 8+2 = 10, out of 5vs9 9 is greater, so 9+4=14 
        //keep going and the topmost number is the highest one.
        /* so   3         turns =>    23      
                7 4                   20 19
                2 4 6                 10 13 15
                8 5 9 3 >> Unchanged> 8 5 9 3
         */
        public long GetMaxTotal()
        {
            for (int i = Rows.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < Rows[i].Count() - 1; j++)
                {
                    int mx = Rows[i][j] > Rows[i][j + 1] ? Rows[i][j] : Rows[i][j + 1];//<< ternary if get larger
                    Rows[i - 1][j] = Rows[i - 1][j] + mx;
                }
            }
            return Rows[0][0];
        }
    }
    class Problem18 : IProblem
    {
        public void Run()
        {
            string input =
                        "75\n" +
                        "95 64\n" +
                        "17 47 82\n" +
                        "18 35 87 10\n" +
                        "20 04 82 47 65\n" +
                        "19 01 23 75 03 34\n" +
                        "88 02 77 73 07 63 67\n" +
                        "99 65 04 28 06 16 70 92\n" +
                        "41 41 26 56 83 40 80 70 33\n" +
                        "41 48 72 33 47 32 37 16 94 29\n" +
                        "53 71 44 65 25 43 91 52 97 51 14\n" +
                        "70 11 33 28 77 73 17 78 39 68 17 57\n" +
                        "91 71 52 38 17 14 91 43 58 50 27 29 48\n" +
                        "63 66 04 68 89 53 67 30 73 16 69 87 40 31\n" +
                        "04 62 98 27 23 09 70 98 73 93 38 53 60 04 23\n";

            Triangle tr = new Triangle(input);
            Console.WriteLine(tr.GetMaxTotal());
        }
    }
}
