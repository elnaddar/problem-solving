// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/U

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemU
    {
        static void Main(string[] args)
        {
            string[] input = ReadLine()!.Split(" ");
            ushort n = ushort.Parse(input[0]);
            ushort a = ushort.Parse(input[1]);
            ushort b = ushort.Parse(input[2]);
            int sum = 0;
            while (n > 0)
            {
                int dig = sumOfDigits(n);
                if (dig >= a && dig <= b)
                {
                    sum += n;
                }
                n--;
            }
            WriteLine(sum);
        }

        static int sumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
