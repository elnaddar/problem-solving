import 'dart:io';
import 'dart:math';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int mn = 0x7FFFFFFFFFFFFFFF;
  int count = b;
  input = stdin.readLineSync()!.split(" "); // take one line input
  int i = 0;
  while (a-- > 0) {
    int n = int.parse(input[i++]);
    mn = min(n, mn);
    if (--count <= 0 || a <= 0) {
      count = b;
      stdout.write("${mn} ");
      mn = 0x7FFFFFFFFFFFFFFF;
    }
  }
}
