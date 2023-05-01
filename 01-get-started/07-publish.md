# 7. publish C# console apps
`dotnet publish --configuration Release`. 

The published output includes the following files: 
- "HelloWorld.deps.json". The appl's runtime dependencies file. Defines the .NET components and the libraries needed to run the app. 
- "HelloWorld.dll". The framework-dependent deployment version of the app. To run ity, enter `dotnet HelloWorld.dll` at a command prompt. It runs on any platform with the .NET runtime installed.
- "HelloWorld.exe" (HelloWorld on Linux, not created on macOS.). The framework-dependent executable version of the app. Is  OS specific.
- "HelloWorld.pdb" (optional for deployment). The debug symbols file. Not required to deploy it along with your app. Save it to debug the published version of your app.
- "HelloWorld.runtimeconfig.json". The app's runtime configuration file. Identifies the version of .NET that your app was built to run on. Can add configuration options to it. 

Ways to run the published app :
- In VS Code Explorer, right-click the "publish" folder, and select Open in Terminal.
- Run the app using the executable. `.\HelloWorld.exe` on Windows. `./HelloWorld` on Linux. Not work on Mac. 
- Use the dll file. Applies to any platform. `dotnet HelloWorld.dll`. 



















