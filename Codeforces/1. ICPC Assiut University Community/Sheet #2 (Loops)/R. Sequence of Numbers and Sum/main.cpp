// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/R
#include <iostream>

using namespace std;

int main()
{
    while (true)
    {
        short n, m;
        cin >> n >> m;
        short mn = min(n, m);
        short mx = max(n, m);
        if (mn <= 0)
            break;

        int sum = 0;
        for (mn; mn <= mx; mn++)
        {
            cout << mn << " ";
            sum += mn;
        }
        cout << "sum =" << sum << endl;
    }
}