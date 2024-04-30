import 'dart:io';
import 'dart:math';

void main() {
  int num = int.parse(stdin.readLineSync()!);
  bool isPrime = true;

  for (int n = 2; n <= num; n++) {
    for (int i = 2; i <= sqrt(n); i++) {
      if (n % i == 0) {
        isPrime = false;
        break;
      }
      isPrime = true;
    }
    if (isPrime) {
      stdout.write("$n ");
    }
  }
}
