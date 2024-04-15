// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/J

#include<iostream>
using namespace std;
 
int main(){
    int x, y;
    cin >> x >> y;
    cout << ((x%y==0 || y%x==0)? "Multiples": "No Multiples");
}