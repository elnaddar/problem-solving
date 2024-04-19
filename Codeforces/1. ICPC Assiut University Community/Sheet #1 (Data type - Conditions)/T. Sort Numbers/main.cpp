// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/T
#include <iostream>
using namespace std;

int main()
{
    int x, y, z, min, mid, max;
    cin >> x >> y >> z;
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
    cout << min << endl;
    cout << mid << endl;
    cout << max << endl
         << endl;
    cout << x << endl;
    cout << y << endl;
    cout << z << endl;
}