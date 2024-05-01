import 'dart:io';
import 'dart:math';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");
  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int mn = min(a, b);
  int gcd = 1;
  for (int i = 1; i <= mn; i++) {
    if (a % i == 0 && b % i == 0) gcd = i;
  }
  print(gcd);
}
