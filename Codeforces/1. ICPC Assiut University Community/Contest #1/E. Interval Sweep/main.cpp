// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/E
#include<iostream>
using namespace std;
 
int main(){
    short a, b;

    cin >> a >> b;
    cout << (a > 0 && (a == b || a-1 == b || a+1 == b)? "YES" : "NO") << endl;
}