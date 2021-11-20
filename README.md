# AnthonysAwesomeArithmeticLibrary
## Overview 


## Requirements
Below are the requirements needed to run this on Windows, all of these can be installed via the Visual Studio Installer.
- Visual Studio 2017/2019
- NuGet.org Package Source for NUnit
- .NET Core 3.1 (Addon during Visual Studio Install)
- dotnet command (Should already be on path once .NET core 3.1 is installed)
## How To Run Project

### Visual Studio

Open ArithmeticLibrary.sln, select ExampleMathApplication on Dropdown, click Play button
![image](https://user-images.githubusercontent.com/2609855/142705468-0a11fd03-13bb-4417-85a0-15437667c9b7.png)

You should see output like this:
![image](https://user-images.githubusercontent.com/2609855/142705509-20bb5cc7-a713-42dd-8078-5253be756543.png)

### Command Line
Open Up Command-Line or Powershell & build the solution (Tests, Application, & Library):
```
dotnet build .\ArithmeticLibrary.sln
```

Now Run the Specific Application Project:
```
dotnet run --project .\ExampleMathApplication\ExampleMathApplication.csproj
```
