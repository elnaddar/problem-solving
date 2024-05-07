// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/Z

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemZ
    {
        static void Main(string[] args)
        {
            string[] input = ReadLine()!.Split(" ");
            uint a, b, i, j, k, count = 0;
            a = uint.Parse(input[0]);
            b = uint.Parse(input[1]);
            for (i = 0; i <= a; i++)
            {
                for (j = 0; j <= a; j++)
                {
                    k = b - (i + j);
                    if (k >= 0 && k <= a)
                        count += 1;
                }
            }
            WriteLine(count);
        }
    }
}
