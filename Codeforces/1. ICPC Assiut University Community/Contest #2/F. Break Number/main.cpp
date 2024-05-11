// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/F
#include <iostream>
#include <cstdio>

using namespace std;

int f(long long x)
{
    unsigned int count = 0;
    while (x > 0)
    {
        if ((x & 1) == 0)
        {
            count++;
            x >>= 1;
        }
        else
        {
            break;
        }
    }
    return count;
}

int main()
{
    int n;
    cin >> n;
    int mx_count = 0;
    while (n-- > 0)
    {
        long long x;
        cin >> x;
        mx_count = max(mx_count, f(x));
    }
    cout << mx_count << endl;
}