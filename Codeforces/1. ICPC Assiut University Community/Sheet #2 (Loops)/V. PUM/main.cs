// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/V

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemV
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(ReadLine()!);
            n *= 4;
            for (int i = 1; i <= n; i++)
            {
                if (i % 4 != 0)
                    Write($"{i} ");
                else
                    WriteLine("PUM");
            }
        }
    }
}
