// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/B

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemB
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input

            int i = Convert.ToInt32(input[0]); // 32 bit int;
            long l = Convert.ToInt64(input[1]); // 64 bit int; 
            char c = Convert.ToChar(input[2]); // 16 bit char;
            float f = Convert.ToSingle(input[3]); // as float is alias for Single dtype
            double d = Convert.ToDouble(input[4]);

            Console.WriteLine($"{i}\n{l}\n{c}\n{f}\n{d}");
        }
    }
}
