import 'dart:io';

void main() {
  String input = stdin.readLineSync()!;
  int opIdx = input.indexOf(RegExp(r'[\+\-\*/]'));
  String op = input[opIdx];
  List<String> parts = input.split(input[opIdx]);

  int a = int.parse(parts[0]);
  int b = int.parse(parts[1]);

  switch (op) {
    case '+':
      print(a + b);
      return;
    case '-':
      print(a - b);
      return;
    case '*':
      print(a * b);
      return;
    case '/':
      print(a ~/ b);
      return;
  }
}
