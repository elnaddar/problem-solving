// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/D

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemD
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]); 
            long c = long.Parse(input[2]); 
            long d = long.Parse(input[3]); 

            bool cond1 = (a + b - c == d) || (a - b + c == d);
            bool cond2 = (a + b * c == d) || (a * b + c == d);
            bool cond3 = (a - b * c == d) || (a * b - c == d);

            Console.WriteLine((cond1 || cond2 || cond3? "YES" : "NO")); 
        }
    }
}
