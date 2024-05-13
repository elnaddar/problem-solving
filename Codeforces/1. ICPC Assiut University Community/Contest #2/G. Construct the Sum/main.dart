import 'dart:io';
import 'dart:math';
import 'dart:io';
void getFactors(int n, int s)
{
    int sum = 0;
    for (int counter = n; counter > 0 && sum != s; counter--)
    {
        if ((sum + counter) <= s)
        {
            sum += counter;
            stdout.write("$counter ");
        }
    }
    stdout.writeln();
}

void main() {
  int t = int.parse(cin());
  while (t-- > 0)
  {
      int n = int.parse(cin());
      int s = int.parse(cin());
      if ((n * (n + 1) / 2) < s)
      {
          stdout.writeln(-1);
      }
      else if (s <= n)
      {
          stdout.writeln(s);
      }
      else
      {
          getFactors(n, s);
      }
  }
}


String cin() {
  StringBuffer input = StringBuffer();
  int? readValue;

  do {
    readValue = stdin.readByteSync();
    if (readValue == -1) {
      // No more characters are available to read
      break;
    }

    var ch = String.fromCharCode(readValue);
    if (ch == '\r') {
      // Carriage return might be read before newline on Windows
      continue;
    }

    if (ch == '\n' || ch == ' ') {
      // Stop reading on newline or space
      break;
    }

    input.write(ch);
  } while (true);

  return input.toString();
}