# B. Basic Data Types

| Data Type in C++ | Size in Memory (C++) | Data Type in C# | Size in Memory (C#) | Data Type in Dart | Size in Memory (Dart) |
|------------------|----------------------|-----------------|---------------------|-------------------|-----------------------|
| int              | 32 bits              | int             | 32 bits             | int               | 64 bits               |
| long long        | 64 bits              | long            | 64 bits             | N/A               | N/A                   |
| char             | 8 bits               | char            | 16 bits             | N/A               | N/A                   |
| float            | 32 bits              | float           | 32 bits             | double            | 64 bits               |
| double           | 64 bits              | double          | 64 bits             | double            | 64 bits               |

### Notes:
1. **C++ 'int' and C# 'int'** both typically represent a 32-bit integer, though this can depend on the system architecture.
2. **C++ 'long long'** is mapped to C# 'long', both representing a 64-bit integer.
3. **C++ `char`** is typically 8 bits and used for characters and symbols. **C# `char`** is slightly different as it uses Unicode characters, hence it is 16 bits.
4. **C++ 'float' and 'double'** are directly analogous to C# 'float' and 'double', respectively, used for floating-point numbers of specified precision.
5. **int in Dart**: Dart's `int` type is a bit different from C++ and C#, as it usually operates as a 64-bit integer on most systems. Dart does not have a direct equivalent for smaller-sized integers used in C++ or C#.
6. **long long in Dart**: Dart does not have a distinct data type equivalent to `long long` in C++ or `long` in C#. Dart’s `int` already covers 64-bit sizes.
7. **char in Dart**: Dart does not use a `char` data type. Characters are typically represented as a `String` of length one, but they can be represented as integers (unicode values), which are 64-bit in Dart.
8. **float and double in Dart**: Dart only supports a `double` data type for floating-point numbers, which is a 64-bit double-precision floating point, conforming to the IEEE 754 standard. This serves as both `float` and `double` from C++/C#.

