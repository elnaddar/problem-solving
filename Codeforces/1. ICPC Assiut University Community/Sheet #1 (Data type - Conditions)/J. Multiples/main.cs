// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/J

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemJ
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);

            Console.WriteLine(((x % y == 0 || y % x == 0) ? "Multiples" : "No Multiples"));
        }
    }
}
