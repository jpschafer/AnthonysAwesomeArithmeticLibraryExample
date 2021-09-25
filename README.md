# AnthonysAwesomeArithmeticLibrary
Reusable library of basic arithmetic functions written in C#.

Measures to make library reusable:  
-Public methods heavily documented, which describes to user what each method does in detail. Makes it easier for potential users to understand.  
-Static class/methods allow library to be invoked without need for creating instances of class. Static methods can be accessed directly in static and non-static methods.   Conceptually, this makes sense for a Math Library, and actually is how the Math library in C# is implemented, as you don't really need/want separate instances.  
-Project is in source control and public. This allows anyone to be able to access the code, and allows for project to easily get updates, and allows for collaboration amongst   other developers.
