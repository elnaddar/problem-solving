// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/B
#include<iostream>
using namespace std;
 
int main(){
    unsigned long long a, b, k;
    cin >> a >> b >> k;
    if(a%k == 0 && b%k==0){
        cout << "Both";
    } else if (a%k == 0){
        cout << "Memo";
    } else if (b%k == 0){
        cout << "Momo";
    } else {
        cout << "No One";
    }
    cout << endl;
}