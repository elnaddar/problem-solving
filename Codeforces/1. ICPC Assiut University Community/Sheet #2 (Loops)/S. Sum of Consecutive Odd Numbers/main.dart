import 'dart:io';
import 'dart:math';

void main() {
  int t = int.parse(stdin.readLineSync()!);

  while (t-- > 0)
  {
    List<String> input = stdin.readLineSync()!.split(" ");
    final int x = int.parse(input[0]);
    final int y = int.parse(input[1]);
    print(sumAllOdds(x, y));
  }
}

int sumAllOdds(int x, int y){
  int mn = min(x, y);
  int mx = max(x, y);

  int i = ((1 & mn) == 1 ? mn + 2 : mn + 1);
  int sum = 0;

  for (; i < mx; i += 2)
  {
    sum += i;
  }

  return sum;
}
