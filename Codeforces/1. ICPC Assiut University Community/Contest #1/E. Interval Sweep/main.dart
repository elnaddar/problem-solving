import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  print((a > 0 && (a == b || a - 1 == b || a + 1 == b) ? "YES" : "NO"));
}
