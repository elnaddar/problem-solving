import 'dart:io';

void main() {
  int t = int.parse(stdin.readLineSync()!);
  while (t-- > 0)
  {
    int n = int.parse(stdin.readLineSync()!);
    do
    {
      stdout.write("${n % 10} ");
      n ~/= 10;
    } while (n > 0);
    stdout.writeln();
  }
}
