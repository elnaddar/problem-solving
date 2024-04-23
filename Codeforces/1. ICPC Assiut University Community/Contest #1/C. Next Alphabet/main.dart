import 'dart:io';

void main() {
  String c = stdin.readLineSync()!;
  c = c == 'z' ? 'a' : (c.codeUnitAt(0) + 1).toString();
  print(c);
}
