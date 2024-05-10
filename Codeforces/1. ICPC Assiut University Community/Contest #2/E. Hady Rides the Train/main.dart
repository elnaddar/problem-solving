import 'dart:io';

void main() {
  int n, row, col;
  n = int.parse(stdin.readLineSync()!);
  row = n ~/ 4;
  col = (1 & row) == 1 ? 3 - (n % 4) : n % 4;
  print("${row} ${col}");
}
