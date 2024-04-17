// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/K

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemK
    {
        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine()); // take one line input
            if (c >= 48 && c <= 57)
            {
                Console.WriteLine("IS DIGIT");
                return;
            }
            else
            {
                Console.WriteLine("ALPHA");
            }
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("IS CAPITAL");
            }
            else
            {
                Console.WriteLine("IS SMALL");
            }

        }
    }
}
