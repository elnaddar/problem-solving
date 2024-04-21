import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[2]);
  int c = int.parse(input[4]);
  int d = 0;

  switch (input[1]) {
    case '+':
      d = a + b;
      break;
    case '-':
      d = a - b;
      break;
    case '*':
      d = a * b;
      break;
  }
  if (c == d) {
    print("Yes");
  } else {
    print(d);
  }
}
