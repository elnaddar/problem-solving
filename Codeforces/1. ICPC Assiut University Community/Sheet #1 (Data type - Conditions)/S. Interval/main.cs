// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/S

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemS
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());
            if (n <= 0 || n > 100)
            {
                Console.WriteLine("Out of Intervals");
            }
            else if (n >= 0 && n <= 25)
            {
                Console.WriteLine("Interval [0,25]");
            }
            else if (n <= 50)
            {
                Console.WriteLine("Interval (25,50]");
            }
            else if (n <= 75)
            {
                Console.WriteLine("Interval (50,75]");
            }
            else
            {
                Console.WriteLine("Interval (75,100]");
            }
        }
    }
}
