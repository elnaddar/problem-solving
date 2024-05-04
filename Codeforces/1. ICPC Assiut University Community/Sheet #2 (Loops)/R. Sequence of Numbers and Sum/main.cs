// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/R

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemR
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = ReadLine()!.Split(" ");
                short n = short.Parse(input[0]);
                short m = short.Parse(input[1]);
                short mn = Min(n, m);
                short mx = Max(n, m);
                if (mn <= 0)
                    break;

                int sum = 0;
                for (; mn <= mx; mn++)
                {
                    Write($"{mn} ");
                    sum += mn;
                }
                Write($"sum ={sum}\n");
            }
        }
    }
}
