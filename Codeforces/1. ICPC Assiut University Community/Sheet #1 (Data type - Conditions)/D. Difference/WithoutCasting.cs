// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/D

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemD
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            long a = Convert.ToInt64(input[0]);
            long b = Convert.ToInt64(input[1]);
            long c = Convert.ToInt64(input[2]);
            long d = Convert.ToInt64(input[3]);

            Console.WriteLine($"Difference = {(a * b) - (c * d)}");
        }
    }
}
