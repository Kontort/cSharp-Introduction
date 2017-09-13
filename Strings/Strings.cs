using System;

namespace Strings
{
	internal class Strings
	{
		private static void Main(string[] args)
		{
			/*
			Console.WriteLine("What is your name?");
			Console.Write("Type your first name: ");
			string firstName;
			firstName = Console.ReadLine();

			string lastName;
			Console.Write("Type your last name: ");
			lastName = Console.ReadLine();
			*/

			Console.Write("Type your first name: ");
			string firstName = Console.ReadLine();
			// This new initialization performs the same task in less commands
			Console.Write("Type your last name: ");
			string lastName = Console.ReadLine();

			Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
			/*These commands do the exact same thing*/
			//	Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
			/*And this*/
			//  Console.WriteLine($"Hello {firstName} {lastName} !");
			Console.ReadKey();
		}
	}
}