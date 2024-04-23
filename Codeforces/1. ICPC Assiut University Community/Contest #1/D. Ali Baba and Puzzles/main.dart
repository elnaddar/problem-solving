import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int d = int.parse(input[3]);

  bool cond1 = (a + b - c == d) || (a - b + c == d);
  bool cond2 = (a + b * c == d) || (a * b + c == d);
  bool cond3 = (a - b * c == d) || (a * b - c == d);

  print((cond1 || cond2 || cond3 ? "YES" : "NO"));
}
