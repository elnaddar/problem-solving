// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/A

using System;

namespace Codeforces.Assuit.Contest2
{
    class ProblemA
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]); 

            Console.WriteLine(((a - b) >= 0 ? (a - b) : 0));
        }
    }
}
