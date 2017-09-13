using System;

namespace Classes
{
	internal class Classes
	{
		private static void Main(string[] args)
		{
			// Creating an object, like a variable
			TestClass theObject;

			// Giving theObject a color, also creating an instance of testclass.
			theObject = new TestClass("Red");
			Console.WriteLine(theObject.Description()); // Description method is called here

			Console.ReadLine();
		}
	}
}