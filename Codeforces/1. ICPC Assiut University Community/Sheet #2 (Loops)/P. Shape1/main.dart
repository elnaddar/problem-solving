import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  for (int i = n; i >= 1; i--) {
    for (int j = 0; j < i; j++)
      stdout.write("*");
    stdout.writeln();
  }
}
