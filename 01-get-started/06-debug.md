# 6. debug C# console apps
Mastering the use of a code debugger is an important skill. 

- Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
- Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
- Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.

A debugger is a software tool used to observe and control the execution flow of your program with an analytical approach. Its primary benefit is that you can watch your program running. You can follow program execution one line of code at a time. This approach minimizes the chance of guessing wrong.

Code to debug: 
```cs
string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};
int studentCount = students.Length;
Console.WriteLine("The final name is: " + students[studentCount]);
```

