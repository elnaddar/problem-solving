// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/G
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short t, n;
    cin >> t;
    while(t--){
        cin >> n;
        unsigned long long fact = n !=0 ? n : 1;
        for(int i=1; i<n; i++){
            fact *= i;
        }
        cout << fact << endl;
    }
}