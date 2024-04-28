// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/D

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemD
    {
        static void Main(string[] args)
        {
            ushort password;
            while(true){
                password = ushort.Parse(Console.ReadLine());
                if(password == 1999) break;
                Console.WriteLine("Wrong");
            }
            Console.WriteLine("Correct");
        }
    }
}
