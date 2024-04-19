import 'dart:io';

void main() {
  double n = double.parse(stdin.readLineSync()!);
  if (n <= 0 || n > 100)
  {
      print("Out of Intervals");
  }
  else if (n >= 0 && n <= 25)
  {
      print("Interval [0,25]");
  }
  else if (n <= 50)
  {
      print("Interval (25,50]");
  }
  else if (n <= 75)
  {
      print("Interval (50,75]");
  }
  else
  {
      print("Interval (75,100]");
  }
}
