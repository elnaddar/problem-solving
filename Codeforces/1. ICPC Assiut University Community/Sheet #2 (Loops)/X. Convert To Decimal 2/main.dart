import 'dart:io';

void main() {
  int t = int.parse(stdin.readLineSync()!);
  while (t-- > 0)
  {
    int n = int.parse(stdin.readLineSync()!);
    int ones = 0;
    while (n > 0)
    {
      ones += 1 & n;
      n >>= 1;
    }
    int bNum = 1;
    while (ones-- > 1)
    {
      bNum <<= 1;
      bNum ^= 1;
    }
    print(bNum);
  }
}
