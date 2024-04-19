// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/R

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemR
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine($"{n/365} years");
            Console.WriteLine($"{(n%=365)/30} months");
            Console.WriteLine($"{n%=30} days");
        }
    }
}
