import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int d = int.parse(input[3]);

  print("Difference = ${(a * b) - (c * d)}");
}
