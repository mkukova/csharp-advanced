using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FilterByAge
{
	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			var people = new Dictionary<string, int>();

			for (int i = 0; i < peopleCount; i++)
			{
				string[] currentPersonInfo = Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries);

				string name = currentPersonInfo[0];
				int age = int.Parse(currentPersonInfo[1]);

				if (!people.ContainsKey(name))
				{
					people[name] = 0;
				}

				people[name] = age;
			}

			string condition = Console.ReadLine();
			int ageFilter = int.Parse(Console.ReadLine());
			string format = Console.ReadLine();

			people = people
				.Where(p => condition == "younger" ? p.Value < ageFilter : p.Value >= ageFilter)
				.ToDictionary(x => x.Key, y => y.Value);

			if (format == "name age")
			{
				foreach ((string name, int age) in people)
				{
					Console.WriteLine($"{name} - {age}");
				}
			}
			else if (format == "name")
			{
				foreach ((string name, int age) in people)
				{
					Console.WriteLine($"{name}");
				}
			}
			else if (format == "name")
			{
				foreach ((string name, int age) in people)
				{
					Console.WriteLine($"{age}");
				}
			}
		}
	}
}
