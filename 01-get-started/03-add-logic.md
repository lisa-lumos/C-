# 3. add logic to C# console app
Note that in Mac terminal, you can combine dotnet build and dotnet run in one command: `dotnet build; dotnet run`. It will run "dotnet run" only if the "dotnet build" was successful. 

```cs
Console.WriteLine("a" == "A"); // False
Console.WriteLine(1 == 2); // False

string myValue = "a";
Console.WriteLine(myValue == "a"); // True

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // True

Console.WriteLine("a" != "A"); // True

Console.WriteLine(1 <= 1); // True

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // True
Console.WriteLine(!pangram.Contains("fox")); // False

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}"); // Discount: 100
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); // Discount: 100

Random rand = new Random();
int flip = rand.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

string permission = "Admin";
int level = 53;
if (permission.Contains("Admin")) 
{
    if (level > 55) 
    {
        Console.WriteLine("Welcome, Super Admin user.");
    } 
    else 
    {
        Console.WriteLine("Welcome, Admin user.");
    }
} 
else if (permission.Contains("Manager")) 
{
    if (level >= 20) 
    {
        Console.WriteLine("Contact an Admin for access.");
    } 
    else 
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} 
else 
{
    Console.WriteLine("You do not have sufficient privileges.");
}
```
















