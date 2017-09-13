using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	internal class TestClass
	{
		private string color; // Allows to store user colors in instance object

		public TestClass(string color)
		{
			// Grabs the string from outside this method, and sets it to the color from the method's parameter.
			this.color = color;
		}

		public string Description()
		{
			// Returns a string with a description.
			return $"This object has been given the color {color}.";
		}

		public string Color
		{
			get
			{
				// Get the most current value, and returns it
				return color;
			}
			set
			{
				// Sets the recently 'get' value to the Color value
				color = value;
			}
		}
	}
}
