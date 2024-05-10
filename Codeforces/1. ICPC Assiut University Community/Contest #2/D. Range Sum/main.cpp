// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/D
#include <iostream>
#include <cstdio>
#include <cmath>

using namespace std;

long long sum(long long const &l, long long const &r)
{
    return (l + r) * (abs(r - l) + 1) / 2;
}

int main()
{
    int t;
    cin >> t;
    while (t-- > 0)
    {
        long long l, r;
        cin >> l >> r;
        cout << sum(l, r) << endl;
    }
}