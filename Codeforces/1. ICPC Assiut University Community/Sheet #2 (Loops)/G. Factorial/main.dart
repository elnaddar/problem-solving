import 'dart:io';

void main() {
  int t, n;
  t = int.parse(stdin.readLineSync()!);
  while (t-- > 0) {
    n = int.parse(stdin.readLineSync()!);
    int fact = (n != 0 ? n : 1);
    for (int i = 1; i < n; i++) {
      fact *= i;
    }
    print(fact);
  }
}
