import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int x = int.parse(input[0]);
  int p = int.parse(input[1]);

  x = 100 - x;
  double result = (p / x) * 100;
  print(result.toStringAsFixed(2));
}
