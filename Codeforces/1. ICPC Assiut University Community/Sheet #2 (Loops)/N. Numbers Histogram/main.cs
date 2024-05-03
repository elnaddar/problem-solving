// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/N

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemN
    {
        static void Main(string[] args)
        {
            char s = char.Parse(ReadLine());
            ushort n = ushort.Parse(ReadLine());
            string[] input = Console.ReadLine().Split(" ");
            ushort i = 0;
            while(n-- > 0){
                ushort x = ushort.Parse(input[i++]);
                while(x-- > 0) Write(s);
                WriteLine();
            }
         }
    }
}
