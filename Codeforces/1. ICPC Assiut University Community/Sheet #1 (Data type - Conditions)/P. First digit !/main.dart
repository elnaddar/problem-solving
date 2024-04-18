import 'dart:io';

void main() {
  int x = int.parse(stdin.readLineSync()!);
  x ~/= 1000;
  print(((x & 1) == 1 ? "ODD" : "EVEN"));
}
