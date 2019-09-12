using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> guests = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			Func<string, string, bool> startsWithFilter = (name, param)
				=> name.StartsWith(param);
			Func<string, string, bool> endsWithFilter = (name, param)
				=> name.EndsWith(param);
			Func<string, int, bool> lengthFilter = (name, length)
				=> name.Length == length;

			string command = Console.ReadLine();

			while (command != "Party!")
			{
				string[] splitttedCommand = command
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string action = splitttedCommand[0];
				string filter = splitttedCommand[1];
				string param = splitttedCommand[2];

				command = Console.ReadLine();
			}
		}
	}
}
