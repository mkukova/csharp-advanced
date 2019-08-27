using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			var continents = new Dictionary<string, Dictionary<string, List<string>>>();

			for (int i = 0; i < count; i++)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string continent = input[0];
				string country = input[1];
				string city = input[2];

				if (!continents.ContainsKey(continent))
				{
					continents[continent] = new Dictionary<string, List<string>>();
				}

				if (!continents[continent].ContainsKey(country))
				{
					continents[continent][country] = new List<string>();
				}

				continents[continent][country].Add(city);
			}

			foreach (var continent in continents)
			{
				Console.WriteLine($"{continent.Key}:");

				foreach (var country in continent.Value)
				{
					string cities = string.Join(", ", country.Value);
					Console.WriteLine($"{country.Key} -> {cities}");
				}
			}
		}
	}
}
