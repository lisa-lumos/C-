# 8. Install and use a package
You refer to installed packages in code with `using namespace `, where `namespace` is often the package name. You can then use the package's API in your project.

Browse "nuget.org/packages" to find packages you can reuse in your own applications. You can search directly at https://nuget.org. 

Steps to install a package named "Newtonsoft.json":
- navigate to your desired proj folder, eg: "MyProj", then `dotnet new console`. `dotnet run` and see "Hello, World!". 
- `dotnet add package Newtonsoft.Json`. You can see this PackageReference in the "MyProj.csproj" file. 
- open the "Program.cs" file and add `using Newtonsoft.Json;` at the top of the file. Then append the following code block. 
- `dotnet build`, then `dotnet run`. Get the output. 

```cs
namespace MyProj
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Name = "John Doe",
                Email = "john@nuget.org",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
            // {
            //   "Name": "John Doe",
            //   "Email": "john@nuget.org",
            //   "DOB": "1980-02-20T00:00:00Z"
            // }
        }
    }
}
```


















