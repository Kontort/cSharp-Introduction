using System;

namespace For_Loops
{
	internal class ForLoop
	{
		private static void Main(string[] args)
		{
			// For Loops are incredibly powerful for when you need to run code multiple amounts of times
			for (int i = 0; i < 8; i++) // Declare variable, specify the condition, and increment
			{
				Console.WriteLine("The value of variable i = {0}", i); //{0} represents the value of i, in the output.
				//  Console.WriteLine("The value of variable i = " + i);
				//  Console.WriteLine($"The value of variable i = {i}");
				
				/*these commands do the exact same thing*/

				Console.ReadLine(); //This waits for you to press enter, you can even write something and the program will store it!

				// When you run the code, pressing enter should give you every loop and its output.
			}
		}
	}
}