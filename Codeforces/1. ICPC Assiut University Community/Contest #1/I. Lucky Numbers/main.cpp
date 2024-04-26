// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/I
#include <iostream>
using namespace std;

int main()
{
    unsigned short a, b;
    cin >> a;
    b = a%10;
    a /= 10;
    if (b == 0 || a%b == 0 || b%a == 0){
        cout << "YES";
    } else {
        cout << "NO";
    }
    cout << endl;
}