using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProblem(new Problem4());
        }
        static void RunProblem(IProblem prob)
        {
            Stopwatch sp = new Stopwatch();
            sp.Start();
            prob.Run();
            sp.Stop();
            Console.WriteLine("Time: " + sp.ElapsedMilliseconds.ToString());
            Console.ReadKey();
        }

    }
}
