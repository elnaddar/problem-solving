import 'dart:io';
import 'dart:math';

void main() {
  int n = int.parse(cin());
  int num, sum = 0;

  while (n-- > 0)
  {
      num = int.parse(cin());
      sum += num;
  }

  print(sum.abs());
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