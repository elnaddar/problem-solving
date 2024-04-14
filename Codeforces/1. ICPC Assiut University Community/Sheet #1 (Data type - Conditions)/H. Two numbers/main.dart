import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");
  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  double div = a / b;

  print("floor ${a} / ${b} = ${div.floor()}");
  print("ceil ${a} / ${b} = ${div.ceil()}");
  print("round ${a} / ${b} = ${div.round()}");
}
