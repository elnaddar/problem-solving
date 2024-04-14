// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/F

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemF1
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            byte a = Convert.ToByte(input[0].Last() - '0');
            byte b = Convert.ToByte(input[1].Last() - '0');

            Console.WriteLine(a+b);
        }
    }
}
