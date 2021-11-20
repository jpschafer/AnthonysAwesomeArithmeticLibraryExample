# AnthonysAwesomeArithmeticLibrary Example Application
## Overview 

This example application is a fork of `AnthonysAwesomeArithmeticLibrary` This allows updates from the library's upstream to be easily consumed and merged back into this repository. In an ideal scenario to keep the library's code better separated on assembly, the library would be consumed as a nuget package, instead of being version controlled as a part of our C# solution.

This application generates two random numbers as well as a 3rd random number representing an exponent. Math is then performed on the numbers via the library. Conversion from integers into the difference base integer formats is done as well. This is all outputted via a command line window.

The Math Example Application resides in a separate project inside of the C# solution to keep the library separated. The Example Application references the library on assembly of the final executable, like referencing a C or C++ library. 

This library has a well defined set of static methods, making it easy to keep in a black box. Testing proved that all of the methods performed as expected, very little work was put into consuming the library. The most work was just using the methods, setting up assembly of the project, and including the library class in the main application class. This is a light work load and is reasonable for the consumption of a black box library.

I commend Tony for the great code documentation as well inside of his library. Thanks to this, it was fairly straightforwand and required little effort on my part to consume, allowing me to focus on building the application.

## Requirements
Below are the requirements needed to run this on Windows, all of these can be installed via the Visual Studio Installer.
- Visual Studio 2017/2019
- NuGet.org Package Source for NUnit
- .NET Core 3.1 (Addon during Visual Studio Install)
- dotnet command (Should already be on path once .NET core 3.1 is installed)
## How To Run Project

Below are a couple of different ways to run the exectuble to test the application, one involves using the IDE, while the other only requires the dotnet CLI executable:
### Visual Studio

Open ArithmeticLibrary.sln, select ExampleMathApplication on Dropdown, click Play button
![image](https://user-images.githubusercontent.com/2609855/142705468-0a11fd03-13bb-4417-85a0-15437667c9b7.png)

You should see output like this:
![image](https://user-images.githubusercontent.com/2609855/142705509-20bb5cc7-a713-42dd-8078-5253be756543.png)

### Command Line
Open Up Command-Line or Powershell, cd into the root of the repository, and build the solution (Tests, Application, & Library):
```
dotnet build .\ArithmeticLibrary.sln
```

Now Run the Specific Application Project:
```
dotnet run --project .\ExampleMathApplication\ExampleMathApplication.csproj
```

you Should have seen output like the following:
```
PS C:\Users\Jason Schafer\Repositories\AnthonysAwesomeArithmeticLibrary> dotnet run --project .\ExampleMathApplication\ExampleMathApplication.csproj
Performing Arithmetic on two Random Numbers between 0-1000: 744 & 590

744 + 590 = 1334
744 - 590 = 154
744 * 590 = 438960
744 / 590 = 1.261017
744^5 = 2.2796316E+14
sqrt(744) = 27.276363

Number Conversions for 744

Binary: 1011101000
Octal: 1350
Hexadecimal: 2e8

 Program Complete! Exiting...
 ```
