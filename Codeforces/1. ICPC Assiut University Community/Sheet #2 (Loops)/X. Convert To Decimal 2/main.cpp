// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/X
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
    unsigned short t;
    cin >> t;
    while (t-- > 0)
    {
        unsigned int n;
        cin >> n;
        unsigned int ones = 0;
        while (n > 0)
        {
            ones += 1 & n;
            n >>= 1;
        }
        unsigned int bNum = 1;
        while (ones-- > 1)
        {
            bNum <<= 1;
            bNum ^= 1;
        }

        cout << bNum << endl;
    }
}