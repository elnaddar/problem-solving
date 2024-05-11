import 'dart:io';
import 'dart:math';
import 'dart:io';

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


int f(int x)
{
  int count = 0;
  while (x > 0)
  {
    if ((x & 1) == 0)
    {
      count++;
      x >>= 1;
    }
    else
    {
      break;
    }
  }
  return count;
}

void main() {
  int n = int.parse(stdin.readLineSync()!);
  int mx_count = 0;
  while (n-- > 0)
  {
    int x = int.parse(cin());
    mx_count = max(mx_count, f(x));
  }
  print(mx_count);
}
