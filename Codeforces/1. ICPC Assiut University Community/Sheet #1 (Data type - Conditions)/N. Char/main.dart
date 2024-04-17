import 'dart:io';

void main() {
  int c = stdin.readLineSync()!.codeUnitAt(0);
  if (c >= "a".codeUnitAt(0) && c <= "z".codeUnitAt(0)) {
    print(String.fromCharCode(c - 32));
  } else {
    print(String.fromCharCode(c + 32));
  }
}
