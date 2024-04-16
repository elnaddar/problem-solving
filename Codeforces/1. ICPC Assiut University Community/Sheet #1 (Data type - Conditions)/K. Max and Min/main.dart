import 'dart:io';
import 'dart:math';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int x = int.parse(input[0]);
  int y = int.parse(input[1]);
  int z = int.parse(input[2]);
  int mn = min(min(x, y), z);
  int mx = max(max(x, y), z);

  print("$mn $mx");
}
