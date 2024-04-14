// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/C

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemC
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {(long)x * y}"); // casting bcs multiplication will be greater than 32 bits
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
    }
}
