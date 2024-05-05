// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/S
#include <iostream>
using namespace std;

unsigned int sumAllOdds(unsigned short const &x, unsigned short const &y)
{
    unsigned short const &mn = min(x, y);
    unsigned short const &mx = max(x, y);

    unsigned short i = (1 & mn) == 1 ? mn + 2 : mn + 1;
    unsigned int sum = 0;

    for (; i < mx; i += 2)
    {
        sum += i;
    }

    return sum;
}

int main()
{
    unsigned short t;
    cin >> t;

    while (t--)
    {
        unsigned short x, y;
        cin >> x >> y;
        cout << sumAllOdds(x, y) << endl;
    }
}