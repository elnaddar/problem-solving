import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  n *= 4;
  for (int i = 1; i <= n; i++)
  {
    if (i % 4 != 0)
      stdout.write("${i} ");
    else
      stdout.writeln("PUM");
  }
}
