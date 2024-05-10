import 'dart:io';
import 'dart:math';

int sum(int l, int r)
{
    return (l + r) * ((r - l).abs() + 1) ~/ 2;
}

void main() {
    int t = int.parse(stdin.readLineSync()!);
    while (t-- > 0)
    {
        List<String> input = stdin.readLineSync()!.split(" ");
        int l = int.parse(input[0]),
            r = int.parse(input[1]);
        stdout.writeln(sum(l, r));
    }
}
