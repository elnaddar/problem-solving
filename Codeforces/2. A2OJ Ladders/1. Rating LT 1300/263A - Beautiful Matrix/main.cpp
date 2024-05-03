// https://codeforces.com/problemset/problem/263/A
#include <bits/stdc++.h>

using namespace std;

int main()
{
    short place;
    short input = 0;
    for (short i = 0; i < 25; i++)
    {
        cin >> input;
        if (input == 1)
            place = i;
    }
    short col = place % 5, row = place / 5;
    cout << abs(col - 2) + abs(row - 2) << endl;
}