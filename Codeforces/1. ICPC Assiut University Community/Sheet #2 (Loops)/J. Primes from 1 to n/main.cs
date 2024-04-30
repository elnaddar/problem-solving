// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/J

using System;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemJ
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int n = 2; n <= num; n++)
            {
                for (int i = 2; i <= Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime)
                {
                    Console.Write("{0} ", arg0:n);
                }
            }
        }
    }
}
