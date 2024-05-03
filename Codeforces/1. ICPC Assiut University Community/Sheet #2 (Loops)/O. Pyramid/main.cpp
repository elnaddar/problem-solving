// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/O
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short n;
    cin >> n;
    for(int i=1; i <= n; i++){
        for(int j=0; j<i; j++)
            cout << "*";
        cout << endl;
    }
}