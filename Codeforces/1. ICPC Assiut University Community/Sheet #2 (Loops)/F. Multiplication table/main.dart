import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  for (int i = 1; i <= 12; i++) {
    print("${n} * ${i} = ${(n * i)}");
  }
}
