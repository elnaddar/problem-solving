// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/E

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemD
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            short a = short.Parse(input[0]);
            short b = short.Parse(input[1]); 
            Console.WriteLine((a > 0 && (a == b || a-1 == b || a+1 == b)? "YES" : "NO")); 
        }
    }
}
