using System;

namespace Decisions
{
	internal class Decisions
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Big 6 Lottery");
			Console.Write("Choose a number: 1, 3, or 5: ");
			string userChoice = Console.ReadLine();
			string message = "";

			if (userChoice == "1")
				message = "You have won a small loan of a million dollars.";
			else if (userChoice == "3")
				message = "You have won absolutely nothing...";
			else if (userChoice == "5")
				message = "You have won a luxurious condominium!";
			else
				Console.WriteLine("You are unable to participate, due to a lack of thinking ability. Please return when you feel that you have a more suitable answer for us.");
			Console.ReadLine();
			Environment.Exit(0);

			Console.WriteLine(message);
			Console.ReadLine();
			/*
			Console.WriteLine("YouTuber Giveaway");
			Console.Write("Choose a number: 2, 4, or 6: ");
			string userChoice = Console.ReadLine();

			string message = (userChoice == "4") ? "All the subscribers" : "nothing";
			Console.Write("You entered {0}, therefore you have won {1}!", userChoice, message);
			Console.ReadKey();
			*/
		}
	}
}