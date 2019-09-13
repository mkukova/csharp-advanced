using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
	class Program
	{
		static void Main(string[] args)
		{
			var comming = Console.ReadLine()
				.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			ExecuteCommands(comming);
			PrintCommingList(comming);
		}

		private static void PrintCommingList(List<string> comming)
		{
			if (comming.Any())
			{
				var names = string.Join(", ", comming);
				Console.WriteLine($"{names} are going to the party!");
			}
			else
			{
				Console.WriteLine("Nobody is going to the party!");
			}
		}

		private static void ExecuteCommands(List<string> comming)
		{
			var command = Console.ReadLine()
				.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

			while (command[0] != "Party!")
			{
				if (command.Length < 3)
				{
					command = Console.ReadLine()
						.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
					continue;
				}

				if (command[1] == "StartsWith")
				{
					ForeachName(command[0], comming, n => n.StartsWith(command[2]));
				}
				else if (command[1] == "EndsWith")
				{
					ForeachName(command[0], comming, n => n.EndsWith(command[2]));
				}
				else if (command[1] == "Length")
				{
					ForeachName(command[0], comming, n => n.Length == int.Parse(command[2]));
				}

				command = Console.ReadLine()
					.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
			}
		}

		private static void ForeachName(string command, List<string> comming, Func<string, bool> condition)
		{
			for (int i = comming.Count - 1; i >= 0; i--)
			{
				if (condition(comming[i]))
				{
					if (command == "Remove")
					{
						comming.RemoveAt(i);
					}
					else if (command == "Double")
					{
						comming.Add(comming[i]);
					}
				}
			}
		}
	}
}

