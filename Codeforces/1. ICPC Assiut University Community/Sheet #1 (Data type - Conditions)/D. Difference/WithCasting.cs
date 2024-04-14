// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/D

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemD
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
            int c = Convert.ToInt32(input[2]);
            int d = Convert.ToInt32(input[3]);

            Console.WriteLine($"Difference = {((long)a * b) - ((long)c * d)}"); // casting bcs multiplication will be greater than 32 bits
        }
    }
}
