import 'dart:io';

void main() {
  String s1 = stdin.readLineSync()!.split(" ")[1];
  String s2 = stdin.readLineSync()!.split(" ")[1];

  print((s1 == s2 ? "ARE Brothers" : "NOT"));
}
