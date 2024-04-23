// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/A

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemA
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            ushort x = ushort.Parse(input[0]);
            uint p = uint.Parse(input[1]); 

            x = (ushort)(100 - x);
            float result = ((float)p/x) * 100;
            Console.WriteLine(result.ToString("F2"));
        }
    }
}
