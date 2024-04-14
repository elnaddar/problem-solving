import 'dart:io';

void main() {
  double r = double.parse(stdin.readLineSync()!);
  print((3.141592653 * r * r).toStringAsFixed(9));
}
