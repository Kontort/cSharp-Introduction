using System; // Importing nessecary funtions (Console)

namespace HelloWorld // namespace - organizes the code (Called by other classes in using directive)
{
	internal class HelloWorld // Class - Container for Methods (List of names)
	{
		private static void Main(string[] args) // Method - Name
		{
			Console.WriteLine("Hello World!"); // Semicolon behaves like a period, more or less
			Console.ReadKey(); // Waits for a keypress.
			//Code will end after ReadKey, since no more code is left to run
		}
	}
}