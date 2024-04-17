import 'dart:io';

void main() {
  int c = stdin.readLineSync()!.codeUnits[0];
  if (c >= 48 && c <= 57) {
    print("IS DIGIT");
    return;
  } else {
    print("ALPHA");
  }
  if (c >= 65 && c <= 90) {
    print("IS CAPITAL");
  } else {
    print("IS SMALL");
  }
}
