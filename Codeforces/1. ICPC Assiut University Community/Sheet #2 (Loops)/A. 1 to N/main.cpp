// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/A
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short x, i = 1;
    cin >> x;
    loop:
        cout << i++ << endl;
        if(i <= x) goto loop;
}