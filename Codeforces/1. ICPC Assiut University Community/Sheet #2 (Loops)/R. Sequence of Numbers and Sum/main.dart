import 'dart:io';
import 'dart:math';

void main() {
  while (true)
  {
    List<String> input = stdin.readLineSync()!.split(" ");
    int n = int.parse(input[0]);
    int m = int.parse(input[1]);
    int mn = min(n, m);
    int mx = max(n, m);
    if (mn <= 0)
      break;

    int sum = 0;
    for (; mn <= mx; mn++)
    {
      stdout.write("${mn} ");
      sum += mn;
    }
    stdout.write("sum =${sum}\n");
  }

}
