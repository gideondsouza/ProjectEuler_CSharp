This is a simple little set of solutions to the problems on ProjectEuler : http://projecteuler.net

My Badge  
![My Euler Badge](http://projecteuler.net/profile/gideondsouza.png)

There is a little bit of a framework. I do a problem by implementing `IProblem`. Each problem goes in a separate file. Reference this in the main and it runs. It also records the milliseconds elapsed.

Example `Problem1.cs`:

    class Problem1 : IProblem
    {
      void Run()//IProblem.Run
      {
        //do your stuff here
      }
    }

Then:

    static void Main()
    {
       RunProblem(new Problem1());
    } //method signature => RunProblem(IProblem p)


Do give me a buzz if you find errors or mistakes or improvements :)