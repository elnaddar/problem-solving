import 'dart:io';

void main() {
  int n = cinInt();
  int tmp = 0;
  for (int i = 0; i < n; i++) {
    tmp = cinInt();
    if (tmp > 0) {
      stdout.write("1 ");
    } else if (tmp < 0) {
      stdout.write("2 ");
    } else {
      stdout.write("0 ");
    }
  }
  print("");
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

int cinInt() => int.parse(cin());
