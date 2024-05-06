import 'dart:io';

int sumOfDigits(int n)
{
  int sum = 0;
  while (n > 0)
  {
    sum += n % 10;
    n ~/= 10;
  }
  return sum;
}

void main() {
  List<String> input = stdin.readLineSync()!.split(" ");
  int n = int.parse(input[0]);
  int a = int.parse(input[1]);
  int b = int.parse(input[2]);
  int sum = 0;
  while (n > 0)
  {
    int dig = sumOfDigits(n);
    if (dig >= a && dig <= b)
    {
      sum += n;
    }
    n--;
  }
  stdout.writeln(sum);
}
