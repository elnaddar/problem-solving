import 'dart:io';

void main() {
  int x = int.parse(stdin.readLineSync()!);
  int i = 1;

  while (i <= x) {
    print(i++);
  }
}
