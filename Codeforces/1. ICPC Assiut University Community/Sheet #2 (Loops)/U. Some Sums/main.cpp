// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/U
#include <iostream>
using namespace std;

int sumOfDigits(int n)
{
    int sum = 0;
    while (n)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int main()
{
    unsigned short n, a, b;
    cin >> n >> a >> b;
    int sum = 0;
    while (n)
    {
        int dig = sumOfDigits(n);
        if (dig >= a && dig <= b)
        {
            sum += n;
        }
        n--;
    }
    cout << sum << endl;
}