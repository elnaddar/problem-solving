import 'dart:io';
import 'dart:math';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  int mx = 0;
  List<String> input = stdin.readLineSync()!.split(" ");

  while (n > 0) {
    int x = int.parse(input[--n]);
    mx = max(mx, x);
  }
  print(mx);
}
