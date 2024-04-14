// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/F

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemF2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            byte a = (byte)(Convert.ToInt64(input[0]) % 10);
            byte b = (byte)(Convert.ToInt64(input[1]) % 10);

            Console.WriteLine(a+b);
        }
    }
}
