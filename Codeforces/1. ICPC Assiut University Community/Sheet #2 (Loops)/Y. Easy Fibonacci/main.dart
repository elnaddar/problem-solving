import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  int fib1 = 0, fib2 = 1;
  while (n-- > 0)
  {
    stdout.write("$fib1 ");
    int tmp = fib1;
    fib1 = fib2;
    fib2 = fib2 + tmp;
  }
}
