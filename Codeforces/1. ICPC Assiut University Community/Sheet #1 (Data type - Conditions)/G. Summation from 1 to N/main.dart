// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/E
// I tried to get a formula that can calculate it.
// after ome calculations I found this: n * (n + 1) / 2
// which can be faster using bitwise shifting: n * (n + 1) >> 1

import 'dart:io';

void main(){
    int n = int.parse(stdin.readLineSync()!);
    print((n * (n + 1) >> 1));
}