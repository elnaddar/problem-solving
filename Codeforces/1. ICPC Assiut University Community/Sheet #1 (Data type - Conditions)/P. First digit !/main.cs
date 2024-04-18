// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/P

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemP
    {
        static void Main(string[] args)
        {
            short x = Convert.ToInt16(Console.ReadLine());
            x /= 1000;
            Console.WriteLine(((x&1) == 1? "ODD" : "EVEN"));
        }
    }
}
