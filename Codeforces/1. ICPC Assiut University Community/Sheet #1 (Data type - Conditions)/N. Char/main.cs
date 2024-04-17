// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/N

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemK
    {
        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            if (Char.IsLower(c))
            {
                Console.WriteLine((char)(c-32));
            }
            else
            {
                Console.WriteLine((char)(c+32));
            }
        }
    }
}
