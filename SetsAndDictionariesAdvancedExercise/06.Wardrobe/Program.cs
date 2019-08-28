using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfInputs = int.Parse(Console.ReadLine());
			var wardrobe = new Dictionary<string, Dictionary<string, int>>();

			for (int i = 0; i < countOfInputs; i++)
			{
				string[] splittedInput = Console.ReadLine()
					.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

				string colour = splittedInput[0];
				string[] clothes = splittedInput[1]
					.Split(",", StringSplitOptions.RemoveEmptyEntries);

				if (!wardrobe.ContainsKey(colour))
				{
					wardrobe[colour] = new Dictionary<string, int>();
				}

				for (int j = 0; j < clothes.Length; j++)
				{
					string currentClothe = clothes[j];

					if (!wardrobe[colour].ContainsKey(currentClothe))
					{
						wardrobe[colour][currentClothe] = 0;
					}

					wardrobe[colour][currentClothe]++;
				}
			}

			string[] searchedItem = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);

			string searchedColour = searchedItem[0];
			string searchedClothe = searchedItem[1];
			bool isSearchedColour = false;

			foreach (var colour in wardrobe)
			{
				Console.WriteLine($"{colour.Key} clothes:");

				if (colour.Key == searchedColour)
				{
					isSearchedColour = true;
				}

				foreach (var clothe in colour.Value)
				{
					if (isSearchedColour && clothe.Key == searchedClothe)
					{
						Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
					}
					else
					{
						Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
					}
				}
			}
		}
	}
}
