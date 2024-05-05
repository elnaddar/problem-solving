// https : // codeforces.com/problemset/problem/271/A
#include <bits/stdc++.h>

using namespace std;

int main()
{
    unsigned short n;
    cin >> n;
    while (true)
    {
        unsigned short arr[10]{0};
        unsigned short x = ++n;
        bool d = true;
        while (x)
        {
            if (++arr[x % 10] == 2)
            {
                d = false;
                break;
            }
            x /= 10;
        }
        if (d)
            break;
    }
    cout << n << endl;
}