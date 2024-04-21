import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int d = int.parse(input[3]);
  int f = a > c ? a : c;
  int l = b > d ? d : b;

  if (f >= a && f <= b && f >= c && f <= d) {
    print("${f} ${l}");
  } else {
    print(-1);
  }
}
