import 'dart:io';
import 'dart:math';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int sum = min(a, min(b, c));
  a -= sum;
  b -= sum;
  c -= sum;

  if (a == 0 || c == 0) {
    print(sum);
  } else {
    a ~/= 2;
    if (a <= c) {
      print(sum + a);
    } else {
      print(sum + c);
    }
  }
}
