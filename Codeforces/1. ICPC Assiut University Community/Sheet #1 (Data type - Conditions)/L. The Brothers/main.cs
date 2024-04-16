// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/L

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemL
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine().Split(' ')[1];
            string s2 = Console.ReadLine().Split(' ')[1];

            Console.WriteLine((s1 == s2 ? "ARE Brothers" : "NOT"));
        }
    }
}
