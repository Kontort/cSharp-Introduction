using System;

namespace Mathematics
{
	internal class Variables
	{
		private static void Main(string[] args)
		{
			/*int x;
			int y;
			int z;*/
			// int x, y, z;

			/*x = 13;
			y = 17;
			z = x + y;*/
			// var x = 13, y = 17, z = x + y;

			/*Try not to use implicitly typed variables, like keyword var, use explicit typed, such as (float, double, string, int, long, char) etc.*/

			int x = 13, y = 17, z = x + y;

			Console.WriteLine(z);
			Console.ReadKey();
		}
	}
}