// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/D
#include<iostream>
using namespace std;
 
int main(){
    long long a, b, c, d;

    cin >> a >> b >> c >> d;

    bool cond1 = (a + b - c == d) || (a - b + c == d);
    bool cond2 = (a + b * c == d) || (a * b + c == d);
    bool cond3 = (a - b * c == d) || (a * b - c == d);

    cout << (cond1 || cond2 || cond3? "YES" : "NO") << endl; 
}