// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/D
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short password;
    while(true){
        cin >> password;
        if (password == 1999) break;
        cout << "Wrong\n";
    }
    cout << "Correct\n";
}