using System;

namespace Methods
{
	internal class MethodsApplication
	{
		private static void Main(string[] args)
		{
			string usernameROOT = "User31"; // Your username the program will check for
			string passwordROOT = "abc123"; // Your password the program will check for

			// Ask the user for their username
			/*
			Console.Write("Type in your username: ");
			string username = Console.ReadLine();

			Console.Write("Type in your password: ");
			string password = Console.ReadLine();
			// The program should now attempt to login
			attemptLogin(username, password); // Parameters that will be used when logging in
			*/

			// Better version below

			Console.Write("Type your username: ");
			string username = Console.ReadLine();

			Console.Write("Type your password: ");
			string password = null; // Value is updated later
			while (true) // Infinite loop, since true can never be changed while using the program
			{
				var key = Console.ReadKey(true); // New variable which hides key inputs on screen
				if (key.Key == ConsoleKey.Enter) // If the key that is being read by Console.ReadKey happens to be enter
				{
					break; // Get out of the infinite loop
				}
				password += key.KeyChar; // All the text we wrote becomes the string
			}
			Console.WriteLine(""); // Allows us to make a space between the login text and password entry
			attemptLogin(username, password);

			// Login Handler
			void attemptLogin(string usernamePARAM, string passwordPARAM) // Where username/passwordPARAM is replaced by the values above
			{
				if ((usernamePARAM == usernameROOT) && (passwordPARAM == passwordROOT))
				{
					Console.WriteLine("Welcome {0}, you have now been logged in!", usernamePARAM);
					Console.ReadKey();
				}
				else // Condition hasnt been met, in which case, this must be an imposter, hence we exit the program :)
				{
					Console.WriteLine("Sorry, your login is incorrect. Exiting now!");
					Console.ReadKey();
				}
			}
		}
	}
}