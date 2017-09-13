using System;

namespace Calculator
{
	internal class CalculatorApplication
	{
		private static void Main(string[] args)
		{
			#region old

			/*
			bool isCalc = true; // Allows us to use an if statement

			Console.WriteLine("Type the first digit you would like to calculate");
			var firstDigit = double.Parse(Console.ReadLine()); // Takes the string that ReadLine will use, and converts it into a double value

			Console.WriteLine("Type the second digit you would life to calculate");
			var secondDigit = double.Parse(Console.ReadLine()); // Takes the string that ReadLine will use, and converts it into a double value

			// I am breaking apart the string for readability, where \n means a line break. (Equivalent to pressing enter in a word document)
			Console.WriteLine("Choose your operator: " + "\n" + "1. Addition [ADD]" + "\n" + "2. Subtraction [SUB]" + "\n" + "3. Multiplication [MUL]" + "\n" + "4. Division [DIV]");

			// Cleaner way to write it below
			//Console.WriteLine("Choose your operator:{0}1. Addition [ADD]{0}2. Subtraction [SUB]{0}3. Multiplication [MUL]{0}4. Division [DIV]", Environment.NewLine);

			var calcOperator = Console.ReadLine();

			//Now we take the values assigned, and we perform the operating function
			if (isCalc)
			{
				if (calcOperator == "ADD") // Case Sensitive
				{
					Console.WriteLine(firstDigit + secondDigit);
					Console.ReadLine();
				}
				else if (calcOperator == "SUB") // Case Sensitive
				{
					Console.WriteLine(firstDigit - secondDigit);
					Console.ReadLine();
				}
				else if (calcOperator == "MUL") // Case Sensitive
				{
					Console.WriteLine(firstDigit * secondDigit);
					Console.ReadLine();
				}
				else if (calcOperator == "DIV") // Case Sensitive
				{
					Console.WriteLine(firstDigit / secondDigit);
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Unable to perform calculations, please make sure the operator is using the correct case (no lower cases)");
					Console.ReadKey();
					Environment.Exit(0);
				}
			}*/

			#endregion old

			#region new

			Console.Write("Type in your first Number: ");
			string one = Console.ReadLine();
			double.TryParse(one, out double firstValue); // Try to parse the string one, and output that value to double firstValue. If succesful, returns true, else returns false

			Console.Write("Type in your second Number: ");
			string two = Console.ReadLine();
			double.TryParse(two, out double secondValue); // Try to parse the string two, and output that value to double secondValue. If succesful, returns true, else returns false

			Console.Write("Type in your operator, \"Add\", \"Subtract\", \"Divide\", \"Multiply\": ");
			string operate = Console.ReadLine();
			try
			{
				Console.WriteLine(calculation(firstValue, secondValue, operate.ToLower())); // ToLower takes every letter of string, and makes them lowercase
				Console.ReadKey();
			}
			catch
			{
				Console.WriteLine("You didn't type a valid operator.");
			}
		}

		private static double calculation(double first, double second, string operation)
		{
			double max = Math.Max(first, second); // Find the bigger value
			double min = Math.Min(first, second); // Find the smaller value

			if (operation == "add") // Addition is insensitive to position, meaning (first + second) = (second + first)
				return first + second;
			else if (operation == "subtract")
				return (max - min);
			else if (operation == "divide")
				return max / min;
			else if (operation == "multiply") // Multiplication is insensitive to position, meaning (first * second) = (second * first)
				return first * second;

			// No condition was met, so we return NaN (Not a Number)
			return double.NaN;
		}

		#endregion new
	}
}