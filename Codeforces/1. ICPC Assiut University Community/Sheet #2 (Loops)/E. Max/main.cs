// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/E

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemE
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            uint max=0;
            string[] input = Console.ReadLine().Split(" ");
            while(n > 0){
                uint x = uint.Parse(input[--n]);
                max = Math.Max(max, x);
            }
            Console.WriteLine(max);
        }
    }
}
