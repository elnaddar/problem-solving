import 'dart:io';

void main() {
  int a = int.parse(stdin.readLineSync()!);
  int b = (a % 10);
  a ~/= 10;
  if (b == 0 || a % b == 0 || b % a == 0) {
    print("YES");
  } else {
    print("NO");
  }
}
