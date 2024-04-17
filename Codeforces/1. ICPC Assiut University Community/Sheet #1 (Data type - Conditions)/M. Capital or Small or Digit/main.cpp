// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/M

#include<iostream>
using namespace std;
 
int main(){
    char c;
    cin >> c;
    if(c >= 48 && c <= 57){
        cout << "IS DIGIT" << endl;
        return 0;
    } else{
        cout << "ALPHA" << endl;
    }
    if (c >= 'A' && c <= 'Z'){
        cout << "IS CAPITAL" << endl;
    } else{
        cout << "IS SMALL" << endl;
    }
}