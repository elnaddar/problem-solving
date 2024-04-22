// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Y

#include <iostream>
#include <cstdio>
using namespace std;

int main() {
    int A, B, C, D;
    cin >> A >> B >> C >> D;
    
    A %= 100;
    B %= 100;
    C %= 100;
    D %= 100;
    
    int result = (((A * B) % 100 * C) % 100 * D) % 100;
    printf("%02d", result);
    
    return 0;
}
