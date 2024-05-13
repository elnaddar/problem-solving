// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/G
#include <iostream>
#include <cstdio>
using namespace std;

void getFactors(long long const &n, long long const &s)
{
    long long sum = 0;
    for (long long counter = n; counter > 0 && sum != s; counter--)
    {
        if ((sum + counter) <= s)
        {
            sum += counter;
            cout << counter << " ";
        }
    }
    cout << endl;
}

int main()
{
    long long t, n, s;
    cin >> t;
    while (t-- > 0)
    {
        cin >> n >> s;
        if ((n * (n + 1) / 2) < s)
        {
            cout << -1 << endl;
        }
        else if (s <= n)
        {
            cout << s << endl;
        }
        else
        {
            getFactors(n, s);
        }
    }
}