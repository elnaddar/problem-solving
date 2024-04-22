import 'dart:io';
import 'dart:math';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int c = int.parse(input[2]);
  int d = int.parse(input[3]);

  double logAB = b * log(a);
  double logCD = d * log(c);

  print((logAB > logCD ? "YES" : "NO"));
}
