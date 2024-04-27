// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/B
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short x, i = 0;
    cin >> x;
    if(x<2){
        cout << -1 << endl;
        return 0;
    }
    loop:
        cout << (i+=2) << endl;
        if(i+1 < x) goto loop;
}