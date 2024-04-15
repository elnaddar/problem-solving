// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/I

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemI
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);

            Console.WriteLine((x >= y ? "Yes" : "No"));
        }
    }
}
