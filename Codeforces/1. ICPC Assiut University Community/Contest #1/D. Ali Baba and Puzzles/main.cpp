// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/C
#include<iostream>
using namespace std;
 
int main(){
    char c;
    cin >> c;
    c = c == 'z'? 'a' : c + 1;
    cout << c << endl;
}