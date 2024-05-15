using System;
using System.IO;
using static System.Console;

int n = cinInt();
int tmp = default;
for (int i = 0; i < n; i++)
{
    tmp = cinInt();
    if(tmp <= 10){
        WriteLine($"A[{i}] = {tmp}");
    }
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

short cinShort(in byte byfferSizeShort = 6) => short.Parse(cin(byfferSizeShort));
ushort cinUShort(in byte byfferSizeUShort = 6) => ushort.Parse(cin(byfferSizeUShort));
int cinInt(in byte byfferSizeInt = 10) => int.Parse(cin(byfferSizeInt));
uint cinUInt(in byte byfferSizeUInt = 10) => uint.Parse(cin(byfferSizeUInt));
long cinLong(in byte byfferSizeLong = 19) => long.Parse(cin(byfferSizeLong));
ulong cinULong(in byte byfferSizeULong = 19) => ulong.Parse(cin(byfferSizeULong));
double cinDouble(in byte byfferSizeDouble = 19) => double.Parse(cin(byfferSizeDouble));