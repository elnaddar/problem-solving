import 'dart:io';

void main() {
  int n = cinInt();
  List<int> a = List.filled(n, 0);
  for (int i = 0; i < n; i++) {
    a[i] = cinInt();
  }

  int x = cinInt();

  for (int i = 0; i < n; i++) {
    if (x == a[i]) {
      print(i);
      return;
    }
  }

  print(-1);
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
