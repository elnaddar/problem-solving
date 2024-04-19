import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  print("${n~/365} years");
  print("${(n%=365)~/30} months");
  print("${n%=30} days");
}
