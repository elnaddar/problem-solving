import 'dart:io';

void main() {
  List<String> input  = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[2]);

  bool isRight = false;
  switch (input[1])
  {
    case '>':
        isRight = a > b; break;
    case '<':
        isRight = a < b; break;
    case '=':
        isRight = a == b; break;
  }

  print((isRight ? "Right" : "Wrong"));
}
