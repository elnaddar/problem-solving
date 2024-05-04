// https://codeforces.com/problemset/problem/266/B
#include <bits/stdc++.h>

using namespace std;

int main()
{
    unsigned short n, t;
    cin >> n >> t;
    string s;
    cin >> s;
    string nS = s;
    unsigned int const &size = s.size() - 1;
    while (t--)
    {
        for (int i = 0; i < size; i++)
        {
            if (s[i] == 'B' && s[i + 1] == 'G')
            {
                char t = s[i];
                nS[i] = nS[i + 1];
                nS[i + 1] = t;
            }
        }
        s = nS;
    }
    cout << nS << endl;
}