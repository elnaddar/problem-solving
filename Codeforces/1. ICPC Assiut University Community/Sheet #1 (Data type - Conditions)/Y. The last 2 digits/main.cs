// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Y

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemY
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);

            a %= 100;
            b %= 100;
            c %= 100;
            d %= 100;

            int result = a * b % 100 * c % 100 * d % 100;
            Console.WriteLine(result.ToString("D2"));
        }
    }
}
