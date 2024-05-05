import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  for (int i = 1; i <= n; i++) {
    for (int j = 0; j < (n - i); j++)
        stdout.write(" ");
    for (int j = 0; j < (i * 2 - 1); j++)
        stdout.write("*");
    stdout.writeln();
  }
}
