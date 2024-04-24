// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/F

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemF
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]); 
            a ^= b;
            Console.WriteLine(a); 
        }
    }
}
