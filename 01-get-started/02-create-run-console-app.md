# 2. create and run C# console app
The IDE for this chapter is VS Code. Need follows:
- Extension: C# from Microsoft. 
- The .NET runtime (a code library that you need to run the code)
  - `dotnet --version` in terminal shows the version if it is already installed. 
  - recommend to use ".NET 7", from "https://dotnet.microsoft.com/download", select .NET SDK Arm64 for mac
  - my dot net version returns "7.0.203". 

## Create, build and run the app
### Create
The .NET SDK includes a CLI, which can be accessed in terminal, to create/build/run console apps. Run `dotnet new console -o ./app1`. Note "./app1" means create a folder app1 inside current folder, and put the app files inside the new folder. Also, the new app is named app1. 
```console
lisa@mac16 ~/D/c/0/code (main)> pwd
/Users/lisa/Desktop/c-sharp/01-get-started/code
lisa@mac16 ~/D/c/0/code (main)> dotnet new console -o ./app1
...
```
After this command, inside the "app1" folder, there are two folders named "bin" and "obj", two files "app1.csproj" and "Program.cs". 

The "Program.cs" file has the following code: 
```cs
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

The first time you edit a .cs file, VS Code may prompt you to add the missing assets to build and debug your app. Select Yes.

### Build
In terminal, navigate to the project folder, and run `dotnet build`:
```console
lisa@mac16 ~/D/c/0/c/app1 (main)> dotnet build
MSBuild version 17.5.1+f6fdcf537 for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
  app1 -> /Users/lisa/Desktop/c-sharp/01-get-started/code/app1/bin/Debug/net7.0/app1.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.30
```

This creates dll files in the ./bin/Debug/net7.0 folder. 

### Run
Run the app using `dotnet run`:
```cd
lisa@mac16 ~/D/c/0/c/app1 (main)> dotnet run
Hello, World!
```


