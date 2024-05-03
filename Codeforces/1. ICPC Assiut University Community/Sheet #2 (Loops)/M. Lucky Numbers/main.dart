import 'dart:io';

bool isLucky(int num) {
  while (num != 0) {
    int digit = num % 10;
    if (digit != 4 && digit != 7) return false;
    num ~/= 10;
  }
  return true;
}

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");
  int a, b;
  bool hasLucky = false;
  a = int.parse(input[0]);
  b = int.parse(input[1]);

  for (a; a <= b; a++) {
    if (isLucky(a)) {
      stdout.write("$a ");
      hasLucky = true;
    }
  }
  if (!hasLucky) print(-1);
}
