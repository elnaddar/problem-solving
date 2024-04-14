// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/E
// I tried to get a formula that can calculate it.
// after ome calculations I found this: n * (n + 1) / 2
// which can be faster using bitwise shifting: n * (n + 1) >> 1

ulong n = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine((n * (n + 1L) >> 1));