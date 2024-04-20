// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/U
#include<iostream>
using namespace std;
 
int main(){
    float n;
    cin >> n;
    short nn = n;

    if(nn == n) {
        cout << "int " << nn << endl;
    } else {
        cout << "float " << nn << " " << n - nn << endl;
    }
}
