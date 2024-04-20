// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/V

#include <iostream>
using namespace std;

int main()
{
    int a, b;
    char s;
    cin >> a >> s >> b;
    bool isRight;
    switch (s)
    {
    case '>':
        isRight = a > b; break;
    case '<':
        isRight = a < b; break;
    case '=':
        isRight = a == b; break;
    }

    cout << (isRight? "Right": "Wrong") << endl;
}