import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int a = int.parse(input[0]);
  int b = int.parse(input[1]);
  int k = int.parse(input[2]);

  if (a % k == 0 && b % k == 0) {
    print("Both");
  } else if (a % k == 0) {
    print("Memo");
  } else if (b % k == 0) {
    print("Momo");
  } else {
    print("No One");
  }
}
