import 'dart:io';
import 'dart:math';

void main() {
  int num = int.parse(stdin.readLineSync()!);
  for (int i = 2; i <= sqrt(num); i++)
  {
    if (num % i == 0)
    {
      stdout.write("NO\n");
      return;
    }
  }
  stdout.write("YES\n");
}
