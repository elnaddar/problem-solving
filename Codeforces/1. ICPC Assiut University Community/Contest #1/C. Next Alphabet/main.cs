// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/C

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemC
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            char c = char.Parse(input[0]);
            c = c == 'z'? 'a' : (char)(c + 1);
            Console.WriteLine(c);
        }
    }
}
