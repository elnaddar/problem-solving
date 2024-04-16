// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/K

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemK
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);
            int z = Convert.ToInt32(input[2]);
            int min = Math.Min(Math.Min(x, y), z);
            int max = Math.Max(Math.Max(x, y), z);
            Console.WriteLine($"{min} {max}");
        }
    }
}
