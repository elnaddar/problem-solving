import 'dart:io';

void main() {
  int x = int.parse(stdin.readLineSync()!);
  int i = 0;
  if (x < 2) {
    print(-1);
    return;
  }
  while (i + 1 < x) {
    print(i += 2);
  }
}
