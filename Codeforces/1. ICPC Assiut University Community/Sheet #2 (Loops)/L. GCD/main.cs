// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/L

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemL
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            ushort a = ushort.Parse(input[0]);
            ushort b = ushort.Parse(input[1]);
            ushort min = Min(a, b);
            ushort gcd = 1;
            for (ushort i=1; i <= min; i++){
                if(a%i==0 && b%i==0) gcd = i;
            }
            WriteLine(gcd);
        }
    }
}
