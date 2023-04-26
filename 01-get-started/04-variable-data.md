# 4. variable data in C# console app
There are two basic categories of data types: value and reference types. 

Simple value types are a set of predefined types provided by C# as keywords. These keywords are aliases for predefined types defined in the .NET Class Library. For example, the C# keyword `int` is an alias of a value type defined in the .NET Class Library as `System.Int32`.

You should use decimal when working with financial data or any scenario where you need an accurate result from a calculation.

```cs
Console.WriteLine("Signed integral types:");
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// Signed integral types:
// sbyte  : -128 to 127
// short  : -32768 to 32767
// int    : -2147483648 to 2147483647
// long   : -9223372036854775808 to 9223372036854775807

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
// Unsigned integral types:
// byte   : 0 to 255
// ushort : 0 to 65535
// uint   : 0 to 4294967295
// ulong  : 0 to 18446744073709551615

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
// Floating point types:
// float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
// double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
// decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

int[] data = new int[3];
```

SQL Server's type system is different from C#'s type system. As a result, some mapping between the two must happen before you can save data into that database.

When in doubt, stick with the basics:
- `int` for most whole numbers
- `decimal` for numbers representing money
- `bool` for true or false values
- `string` for alphanumeric value

Think through your choices, and unless you have a good reason, try to stick with the basic types like int, decimal, string, and bool.










