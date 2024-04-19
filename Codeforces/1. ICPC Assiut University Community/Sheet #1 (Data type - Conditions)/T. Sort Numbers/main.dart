import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int x, y, z, min, mid, max;
  x = (int.parse(input[0]));
  y = (int.parse(input[1]));
  z = (int.parse(input[2]));

  min = x < y ? x : y;
  max = x >= y ? x : y;

  if (z > min)
  {
      if (z > max)
      {
          mid = max;
          max = z;
      }
      else
      {
          mid = z;
      }
  }
  else
  {
      mid = min;
      min = z;
  }
  print(min);
  print(mid);
  print(max);
  print("");
  print(x);
  print(y);
  print(z);
}
