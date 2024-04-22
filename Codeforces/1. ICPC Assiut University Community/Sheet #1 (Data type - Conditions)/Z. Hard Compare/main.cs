// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Z

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemZ
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = int.Parse(input[0]);
            long b = long.Parse(input[1]);
            int c = int.Parse(input[2]);
            long d = long.Parse(input[3]);

            double logAB = b * Math.Log(a);
            double logCD = d * Math.Log(c);

            Console.WriteLine((logAB > logCD? "YES" : "NO"));
        }
    }
}
