// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/G
#include <iostream>
using namespace std;

int main()
{
    long long a, b, c;
    cin >> a >> b >> c;
    long long sum = min(a, min(b, c));
    a -= sum;
    b -= sum;
    c -= sum;

    if(a == 0 || c == 0){
        cout << sum;
    } else{
        a /= 2;
        if( a <= c){
            cout << sum + a;
        }else{
            cout << sum + c;
        }
    }
    cout << endl;
}