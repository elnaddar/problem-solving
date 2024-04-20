// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/R

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemR
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());
            short nn = (short)n;
            if (nn == n)
            {
                Console.WriteLine("int " + nn);
            }
            else
            {
                Console.WriteLine($"float {nn} {n - nn}");
            }
        }
    }
}
