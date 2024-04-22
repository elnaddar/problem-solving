import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int d = int.parse(input[3]);

  a %= 100;
  b %= 100;
  c %= 100;
  d %= 100;

  int result = a * b % 100 * c % 100 * d % 100;
  print(result.toString().padLeft(2, "0"));
}
