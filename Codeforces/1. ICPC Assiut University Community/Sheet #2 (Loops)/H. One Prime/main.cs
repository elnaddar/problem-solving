// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/H

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemH
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());

            for (int i = 2; i <= Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    Write("NO\n");
                    return;
                }
            }
            Write("YES\n");
        }
    }
}
