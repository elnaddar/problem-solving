import 'dart:io';

void main() {
  double n = double.parse(stdin.readLineSync()!);
  int nn = n.toInt();
  if (nn == n)
  {
      print("int ${nn}");
  }
  else
  {
      print("float ${nn} ${n - nn}");
  }
}
