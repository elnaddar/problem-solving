// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/Q
#include <iostream>

using namespace std;

int main()
{
    unsigned short t;
    cin >> t;
    while (t--)
    {
        int n;
        cin >> n;

        do
        {
            cout << (n % 10) << " ";
            n /= 10;
        } while (n);
        cout << endl;
    }
}