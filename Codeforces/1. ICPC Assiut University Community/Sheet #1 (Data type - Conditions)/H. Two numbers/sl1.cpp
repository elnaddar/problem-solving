#include <iostream>
#include <cstdio>
using namespace std;

int ceil(const float &div)
{
    int iDiv = (int)div;
    return iDiv == div ? iDiv : iDiv + 1;
}

int round(const float &div)
{
    int iDiv = (int)div;
    return (iDiv + 0.5) <= div ? iDiv + 1 : iDiv;
}

int main()
{
    int a, b;
    cin >> a >> b;
    float div = (float)a / b;
    printf("floor %d / %d = %d\n", a, b, (int)div);
    printf("ceil %d / %d = %d\n", a, b, ceil(div));
    printf("round %d / %d = %d\n", a, b, round(div));
}