import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int mul = a * b;
  double eq = mul / c;
  if (mul % c == 0) {
    if (eq.toInt() <= 2147483647) {
      print("int");
    } else {
      print("long long");
    }
  } else {
    print("double");
  }
}
