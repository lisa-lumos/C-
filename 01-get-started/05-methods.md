# 5. methods in C# console app
A method can be called before or after its definition. It's common to define all methods at the end of a program. Method names should be Pascal case and descriptive, such as `void DisplayDate(string month, int day, int year);`. 

```cs
SayHello();
void SayHello() 
{
    Console.WriteLine("Hello World!");
}
```

```cs
int[] a = {1,2,3,4,5};
Console.WriteLine("Contents of Array:");
PrintArray();
// Contents of Array:
// 1 2 3 4 5 

void PrintArray() 
{
    foreach (int x in a) 
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
```

```cs
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()  
{
    Random random = new Random();
    for (int i = 0; i < 5; i++)  
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
    Console.WriteLine();
}
```

```cs
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
}

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        if (int.Parse(number) > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
```

```cs
string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Random random = new Random();
int luck = random.Next(100);
TellFortune();

void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    // string[] fortune = good; // now both references point to the same string array
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral)); 
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
```








