import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int i = int.parse(input[0]);
  int l = int.parse(input[1]); // as no long in dart and int has 64 bits by default
  String c = input[2]; // as no char data type in dart
  double f = double.parse(input[3]);
  double d = double.parse(input[4]);

  print("${i}\n${l}\n${c}\n${f}\n${d}");
}
