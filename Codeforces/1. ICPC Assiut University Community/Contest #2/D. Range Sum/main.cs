// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/D

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest2
{
    class ProblemD
    {
        static long sum(long l, long r)
        {
            return (l + r) * (Abs(r - l) + 1) / 2;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(ReadLine());
            while (t-- > 0)
            {
                string[] input = ReadLine()!.Split(" ");
                long l = int.Parse(input[0]),
                     r = int.Parse(input[1]);
                WriteLine(sum(l, r));
            }
        }
    }
}
