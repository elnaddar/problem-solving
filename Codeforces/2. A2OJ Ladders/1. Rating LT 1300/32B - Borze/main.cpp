// https://codeforces.com/problemset/problem/32/B
#include <bits/stdc++.h>
using namespace std;

void replace(string &s, string const &toReplace, string const &replaceWith)
{
    int find = -1;
    while ((find = s.find(toReplace, find + 1)) != -1)
    {
        s.replace(find, toReplace.size(), replaceWith);
    }
}

int main()
{
    string s;
    cin >> s;
    replace(s, "--", "2");
    replace(s, "-.", "1");
    replace(s, ".", "0");
    cout << s << endl;
}