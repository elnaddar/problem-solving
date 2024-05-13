using System;
using static System.Console;
using System.IO;

ushort t = ushort.Parse(cin(3));
while (t-- > 0)
{
    uint n = uint.Parse(cin(6));
    ulong s = ulong.Parse(cin());
    if (((ulong)n * (ulong)(n + 1) / 2) < s)
    {
        WriteLine(-1);
    }
    else if (s <= n)
    {
        WriteLine(s);
    }
    else
    {
        getFactors(n, s);
    }
}

void getFactors(uint n, ulong s)
{
    ulong sum = 0;
    StreamWriter writer = new(Console.OpenStandardOutput());

    for (uint counter = n; sum != s && counter > 0; counter--)
    {
        if ((sum + counter) <= s)
        {
            sum += counter;
            writer.Write("{0} ", counter.ToString());
        }
    }
    writer.WriteLine("");
    writer.Close();
}

string cin(in byte bufferSize = 19)
{
    char[] buffer = new char[bufferSize]; // Assuming input won't be longer than 19 characters
    int index = 0;
    char ch;

    do
    {
        int readValue = Console.Read();
        if (readValue == -1) // No more characters are available to read
            break;
        ch = (char)readValue;

        if (ch == '\r' || (ch == '\n' && index == 0) || (ch == ' ' && index == 0)) // Carriage return might be read before newline on Windows
            continue;
        if (ch == '\n' || ch == ' ') // Stop reading on newline or space
            break;

        buffer[index++] = ch;
    } while (index < buffer.Length);

    return new string(buffer, 0, index);
}
