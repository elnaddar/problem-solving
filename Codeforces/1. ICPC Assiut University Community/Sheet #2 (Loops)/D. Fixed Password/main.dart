import 'dart:io';

void main() {
  while (true) {
    int password = int.parse(stdin.readLineSync()!);
    if (password == 1999) break;
    print("Wrong");
  }
  print("Correct");
}
