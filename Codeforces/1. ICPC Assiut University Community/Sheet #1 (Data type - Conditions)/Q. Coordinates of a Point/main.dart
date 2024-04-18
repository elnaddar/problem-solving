import 'dart:io';

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");
  double x = double.parse(input[0]);
  double y = double.parse(input[1]);

  if (x == 0 && y == 0)
    print("Origem");
  else if (x == 0)
    print("Eixo Y");
  else if (y == 0)
    print("Eixo X");
  else if (x > 0) {
    if (y > 0)
      print("Q1");
    else
      print("Q4");
  } else {
    if (y > 0)
      print("Q2");
    else
      print("Q3");
  }
}
