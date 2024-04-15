import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");

  int x = int.parse(input[0]);
  int y = int.parse(input[1]);

  print(((x%y==0 || y%x==0)? "Multiples": "No Multiples"));
}
