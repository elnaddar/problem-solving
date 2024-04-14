import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]) % 10;
  int b = int.parse(input[1]) % 10;

  print(a + b);
}
