import 'dart:io';

void main() {
  int a = int.parse(stdin.readLineSync()!);
  for (int i = 0; i < a; i++)
  {
      for (int j = 0; j < a; j++)
      {
          if (i == (a ~/ 2) && j == i)
          {
              stdout.write("X");
          }
          else if (j == i)
          {
              stdout.write("\\");
          }
          else if (j == (a - 1 - i))
          {
              stdout.write("/");
          }
          else
          {
              stdout.write("*");
          }
      }
      stdout.writeln();
  }
}
