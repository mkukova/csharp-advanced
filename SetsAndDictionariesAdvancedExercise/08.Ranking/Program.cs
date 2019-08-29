using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
	class Program
	{
		static void Main(string[] args)
		{
			var contestsList = new Dictionary<string, string>();
			var usernamesList = new SortedDictionary<string, Dictionary<string, int>>();
			string input = Console.ReadLine();

			while (input != "end of contests")
			{
				string[] splittedInput = input
					.Split(":", StringSplitOptions.RemoveEmptyEntries);
				string contest = splittedInput[0];
				string password = splittedInput[1];

				if (!contestsList.ContainsKey(contest))
				{
					contestsList.Add(contest, password);
				}

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			while (input != "end of submissions")
			{
				string[] splittedInput = input
									.Split("=>");
				string contest = splittedInput[0];
				string password = splittedInput[1];
				string username = splittedInput[2];
				int points = int.Parse(splittedInput[3]);

				if (contestsList.ContainsKey(contest) && contestsList[contest] == password)
				{
					if (!usernamesList.ContainsKey(username))
					{
						usernamesList.Add(username, new Dictionary<string, int>());
					}

					if (!usernamesList[username].ContainsKey(contest))
					{
						usernamesList[username].Add(contest, points);
					}

					if (usernamesList[username][contest] < points)
					{
						usernamesList[username][contest] = points;
					}
				}

				input = Console.ReadLine();
			}

			int maxPoints = int.MinValue;
			string bestCandidate = string.Empty;

			foreach (var candidate in usernamesList)
			{
				int totalPoints = candidate.Value.Values.Sum();

				if (totalPoints > maxPoints)
				{
					maxPoints = totalPoints;
					bestCandidate = candidate.Key;
				}
			}

			Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
			Console.WriteLine("Ranking:");

			foreach (var student in usernamesList)
			{
				Console.WriteLine($"{student.Key}");

				foreach (var contest in student.Value.OrderByDescending(x => x.Value))
				{
					Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
				}
			}
		}
	}
}
