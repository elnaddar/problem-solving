// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/T

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemT
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            int x, y, z, min, mid, max;
            x = (Convert.ToInt32(input[0]));
            y = (Convert.ToInt32(input[1]));
            z = (Convert.ToInt32(input[2]));

            min = x < y ? x : y;
            max = x >= y ? x : y;

            if (z > min)
            {
                if (z > max)
                {
                    mid = max;
                    max = z;
                }
                else
                {
                    mid = z;
                }
            }
            else
            {
                mid = min;
                min = z;
            }
            Console.WriteLine(min);
            Console.WriteLine(mid);
            Console.WriteLine(max);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
