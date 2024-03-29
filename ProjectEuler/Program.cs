﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProblem(new Problem25());
        }
        //maybe this could change into some kind of reflection program that could pick up the latest program
        static void RunProblem(IProblem prob)
        {
            Stopwatch sp = new Stopwatch();
            sp.Start();
            prob.Run();
            sp.Stop();
            if (sp.ElapsedMilliseconds > 1000)
            {
                Console.WriteLine("Time Elapsed in Seconds: " + sp.Elapsed.TotalSeconds.ToString());
            }
            else
            {
                Console.WriteLine("Time Elapsed in Milliseconds: " + sp.ElapsedMilliseconds.ToString());
            }
            Console.ReadKey();
        }

    }
}
