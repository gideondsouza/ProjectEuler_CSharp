/*
Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, 
 * begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical 
 * position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
 * So, COLIN would obtain a score of 938  53 = 49714.

What is the total of all the name scores in the file?
 * http://projecteuler.net/problem=22
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler.Problems
{
    class Problem22 : IProblem
    {
        string az = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public void Run()
        {
            int score = 0;
            string input = "";
            Console.WriteLine("Enter path to file, if file doesn't exist nothing happens");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                input = File.ReadAllText(path);
                int i = 1;
                foreach (var item in input.Split(',').OrderBy(s => s))
                {
                    score += GetNameScore(item.Substring(1, item.Length - 2), i++);
                }
            }
            Console.WriteLine(score);
        }
        int GetNameScore(string name, int index)
        {
            int s = 0;
            for (int i = 0; i < name.Length; i++)
            {
                s += az.IndexOf(name[i]) + 1;
            }
            return s * index;
        }

    }

}
