using System;
using ArithmeticLibrary.AnthonysAwesomeArithmeticOperations;
namespace ExampleMathApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();
			var num1 = rand.Next(0, 1000);
			var num2 = rand.Next(0, 1000);
			var exponent = rand.Next(0, 10);

			Console.WriteLine("Performing Arithmetic on two Random Numbers between 0-1000: " + num1 + " & " + num2 + "\n");

			var additionResult = AnthonysAwesomeArithmeticOperations.Add(num1, num2);
			var subtractionResult = AnthonysAwesomeArithmeticOperations.Subtract(num1, num2);
			var multiplicationResult = AnthonysAwesomeArithmeticOperations.Multiply(num1, num2);
			var divisionResult = AnthonysAwesomeArithmeticOperations.Divide(num1, num2);
			var exponentiationResult = AnthonysAwesomeArithmeticOperations.Exponent(num1, exponent);
			var squareRootResult = AnthonysAwesomeArithmeticOperations.SquareRoot(num1);

			Console.WriteLine(num1 + " + " + num2 + " = " + additionResult);
			Console.WriteLine(num1 + " - " + num2 + " = " + subtractionResult);
			Console.WriteLine(num1 + " * " + num2 + " = " + multiplicationResult);
			Console.WriteLine(num1 + " / " + num2 + " = " + divisionResult);
			Console.WriteLine(num1 + "^" + exponent + " = " + exponentiationResult);
			Console.WriteLine("sqrt(" + num1 + ") = " + squareRootResult );

			Console.WriteLine("\nNumber Conversions for " + num1 + "\n");
			Console.WriteLine("Binary: " + AnthonysAwesomeArithmeticOperations.IntegerToBinary(num1));
			Console.WriteLine("Octal: " + AnthonysAwesomeArithmeticOperations.IntegerToOctal(num1));
			Console.WriteLine("Hexadecimal: " + AnthonysAwesomeArithmeticOperations.IntegerToHexadecimal(num1));

			Console.WriteLine("\n Program Complete! Exiting...");
		}
	}
}
