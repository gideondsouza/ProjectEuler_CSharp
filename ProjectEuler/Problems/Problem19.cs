/*
        You are given the following information, but you may prefer to do some research for yourself.

        1 Jan 1900 was a Monday.
        Thirty days has September,
        April, June and November.
        All the rest have thirty-one,
        Saving February alone,
        Which has twenty-eight, rain or shine.
        And on leap years, twenty-nine.
        A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
 
        How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
 * http://projecteuler.net/problem=19
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{//this is awesomely simple with the DateTime structure
    public class Problem19 : IProblem
    {
        int count = 0;
        int totalDays = (new DateTime(2000, 12, 31) - new DateTime(1901, 1, 1)).Days;
        DateTime startDate = new DateTime(1901, 1, 1);
        public void Run()
        {
            for (int i = 1; i <= totalDays; i++)
            {
                DateTime dt = startDate.AddDays(i);
                if (dt.DayOfWeek == DayOfWeek.Sunday && dt.Day == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
