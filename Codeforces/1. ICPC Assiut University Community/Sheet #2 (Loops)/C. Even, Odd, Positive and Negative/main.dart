import 'dart:io';

void main() {
  int n = int.parse(stdin.readLineSync()!);
  int even = 0, odd = 0, pos = 0, neg = 0;
  List<String> input = stdin.readLineSync()!.split(" ");

  while (n > 0) {
    int x = int.parse(input[--n]);
    if ((x & 1) == 1)
      ++odd;
    else
      ++even;

    if (x > 0)
      ++pos;
    else if (x < 0) ++neg;
  }
  print("Even: ${even}");
  print("Odd: ${odd}");
  print("Positive: ${pos}");
  print("Negative: ${neg}");
}
