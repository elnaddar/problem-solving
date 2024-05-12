// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/G
#include <iostream>
#include <cstdio>
using namespace std;

long long sum(long long const &l, long long const &r)
{
    return (l + r) * (abs(r - l) + 1) / 2;
}

void getFactors(long long const &n, long long const &s)
{
    long long counter = n;
    long long sum = 0;
    while (counter > 0)
    {
        if ((sum + counter) > s)
        {
            counter--;
            continue;
        }
        else
        {
            sum += counter;
        }
        cout << counter << " ";
        if (sum == s)
        {
            break;
        }
        counter--;
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
        if (s <= n)
        {
            cout << s - 1 << " " << 1 << endl;
        }
        else
        {
            long long sm = sum(1, n);
            if (sm >= s)
            {
                getFactors(n, s);
            }
            else
            {
                cout << -1 << endl;
            }
        }
    }
}