import 'dart:io';

void main() {
  int x, pal = 0;
  x = int.parse(stdin.readLineSync()!);
  int new_x = x;
  while (new_x > 0) {
    pal *= 10;
    pal += new_x % 10;
    new_x ~/= 10;
  }
  print(pal);
  print((pal == x ? "YES" : "NO"));
}
