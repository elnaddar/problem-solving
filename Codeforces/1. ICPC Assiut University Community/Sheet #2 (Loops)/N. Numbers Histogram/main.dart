import 'dart:io';

void main() {
  String s = stdin.readLineSync()!;
  int n = int.parse(stdin.readLineSync()!);
  List<String> input = stdin.readLineSync()!.split(" ");

  int i = 0;
  while (n-- > 0) {
    int x = int.parse(input[i++]);
    while (x-- > 0) stdout.write(s);
    print("");
  }
}
