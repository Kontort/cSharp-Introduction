using System;

namespace StoringData
{
	internal class Counting
	{
		private static void Main(string[] args)
		{
			Console.Write("Type in something: ");
			var input = Console.ReadLine();

			try
			{
				var parsed = double.Parse(input); // If the user types in anything other than a double, the code will fall into the catch.
				Console.WriteLine((parsed * parsed) / parsed); // Equals parsed
				Console.ReadKey();
			}
			catch
			{
				Console.Clear();
				Console.WriteLine("You didn't type in a number when asked.");
				Console.ReadLine();
			}
		}
	}
}