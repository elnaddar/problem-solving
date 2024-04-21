// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/X

#include <iostream>
using namespace std;

int main()
{
    int a, b, c, d;
    cin >> a >> b >> c >> d;
    int f = a > c ? a : c;
    int l = b > d ? d : b;

    if (f >= a && f <= b && f >= c && f <= d){
        cout << f << " " << l << endl;
    } else{
        cout << -1 << endl;
    }
}