import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");
  int a, b, i, j, k, count = 0;
  a = int.parse(input[0]);
  b = int.parse(input[1]);
  for (i = 0; i <= a; i++)
  {
    for (j = 0; j <= a; j++)
    {
      k = b - (i + j);
      if (k >= 0 && k <= a)
        count += 1;
    }
  }
  print(count);
}
