// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/S

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemS
    {
        static void Main(string[] args)
        {
            ushort t = ushort.Parse(ReadLine());

            while (t-- > 0)
            {
                string[] input = ReadLine()!.Split(" ");
                ushort x = ushort.Parse(input[0]);
                ushort y = ushort.Parse(input[1]);
                WriteLine(SumAllOdds(x, y));
            }
        }
        static uint SumAllOdds(in ushort x, in ushort y){
            ushort mn = Min(x, y);
            ushort mx = Max(x, y);

            ushort i = (ushort)((1 & mn) == 1 ? mn + 2 : mn + 1);
            uint sum = 0;

            for (; i < mx; i += 2)
            {
                sum += i;
            }

            return sum;
        }
    }
}
