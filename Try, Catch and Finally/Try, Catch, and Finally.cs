using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_and_Finally
{
	class Try_Catch_and_Finally
	{
		static void Main(string[] args)
		{
			// Try is usually used to obtain and attempt certain operations
			// Catch is to find and deal with anything "thrown" in try
			// Finally performs the final operations of the try.

			/*
			Console.WriteLine("Press enter to begin");
			Console.ReadLine();
			try
			{
				throw new Exception(); // Creates an error reference in the program, which is handled by catch
			}
			catch(Exception e) // Catch an exception, which will find an error within your code, and report back
			{
				Console.WriteLine("We caught our mistake, and we can report back here. Try using a detailed explanation, like \"Critical error, dynamic link libraries missing!\"");
				Console.WriteLine(Environment.NewLine); // Creates a new line
				Console.WriteLine($"An example of a more detailed, developer type response would be {e}");
			}
			finally
			{
				Console.WriteLine(Environment.NewLine);
				Console.WriteLine("We are now in the finally reference. The issue will have been dealt with, if the issue existed at all, and the process will come to a close"
					+ "You will want to perform last changes, such as changing user stuff, or storing user info.");
			}
			*/

			// More pratical use below

			string userPassword; // Is empty, meaning the user hasnt set a password

			Console.WriteLine("Please set a password.");
			string password = Console.ReadLine();

			Console.WriteLine("Please retype your password to confirm");
			string confirmPassword = Console.ReadLine();
			try
			{
				if (password == confirmPassword)
				{
					userPassword = password;
				}
				else
				{
					throw new Exception(); // User didn't follow instructions, and the program reports this. This triggers catch
				}
			}
			catch(Exception e)
			{
				Console.Clear(); // Clears the console screen of all text
				Console.WriteLine("Your passwords don't match. Details below");
				Console.WriteLine(Environment.NewLine);
				Console.WriteLine(e);

				Console.ReadLine();

				Environment.Exit(0);
			}
			finally
			{
				Console.Clear();
				Console.WriteLine("Password has been succesfully set");
			}

			Console.ReadKey();
		}
	}
}
