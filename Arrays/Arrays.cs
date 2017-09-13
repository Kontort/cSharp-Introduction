using System;

namespace Arrays
{
	internal class Arrays // Arrays hold a collection of items, and it very efficient.
	{
		private static void Main(string[] args)
		{
			/* var[] varArray = new var[4]; */ // This does NOT work, since a variable isnt declared, yet we try to have it contain a list, or array.
			/* int[] intArray = new int[4]; */ // We create an array that will holds integers. Then we assign it to hold a certain amount of integers, in our case 4. We will assign the values below

			// The array is given its values, and every first array value starts with 0.
			/* This isnt nessecary with the better initialization below
			intArray[0] = 5;
			intArray[1] = 17;
			intArray[2] = 6;
			intArray[3] = 31;
			*/

			/* int[] intArray = new int[4] { 5, 17, 6, 31 }; */ // Even better initialization below
			int[] intArray = { 5, 17, 6, 31 };

			/* Array.Sort(intArray); */ // Sorts the array into least to greatest, depending on the values.

			/*
			for (int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine($"The value in arrayValue[{i}] is {intArray[i]}");
				// Type the values of the array, using variable i as a medium. Since i will be 0, it calls the first array type, then i is incremented by one, so the second array type is called.
			}
			*/

			foreach (int i in intArray) // For however many integers exist within our array
			{
				Console.WriteLine(i); // Write their values, in this case, the values you assign to the arrays above
			}
			Console.ReadLine();
		}
	}
}