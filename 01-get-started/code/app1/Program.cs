// Console.WriteLine("Hello, World!");

// Console.WriteLine("a" == "A"); // False
// Console.WriteLine(1 == 2); // False

// string myValue = "a";
// Console.WriteLine(myValue == "a"); // True

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // True

// Console.WriteLine("a" != "A"); // True

// Console.WriteLine(1 <= 1); // True

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox")); // True
// Console.WriteLine(!pangram.Contains("fox")); // False

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}"); // Discount: 100
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); // Discount: 100

// Random rand = new Random();
// int flip = rand.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// string permission = "Admin";
// int level = 53;
// if (permission.Contains("Admin")) {
//     if (level > 55) {
//         Console.WriteLine("Welcome, Super Admin user.");
//     } else {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// } else if (permission.Contains("Manager")) {
//     if (level >= 20) {
//         Console.WriteLine("Contact an Admin for access.");
//     } else {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// } else {
//     Console.WriteLine("You do not have sufficient privileges.");
// }


// Console.WriteLine("Signed integral types:");
// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
// // Signed integral types:
// // sbyte  : -128 to 127
// // short  : -32768 to 32767
// // int    : -2147483648 to 2147483647
// // long   : -9223372036854775808 to 9223372036854775807

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");
// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
// // Unsigned integral types:
// // byte   : 0 to 255
// // ushort : 0 to 65535
// // uint   : 0 to 4294967295
// // ulong  : 0 to 18446744073709551615

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
// // Floating point types:
// // float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
// // double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
// // decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

// int[] data = new int[3];

// SayHello();

// void SayHello() {
//     Console.WriteLine("Hello World!");
// }

// int[] a = {1,2,3,4,5};

// Console.WriteLine("Contents of Array:");
// PrintArray();
// // Contents of Array:
// // 1 2 3 4 5 

// void PrintArray() {
//     foreach (int x in a) {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// }

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }



// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// Random random = new Random();
// int luck = random.Next(100);
// TellFortune();

// void TellFortune() 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     // string[] fortune = good; // assign reference name to another reference, they all point to the same string array
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral)); 
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

// string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};
// int studentCount = students.Length;
// Console.WriteLine("The final name is: " + students[studentCount]);
