using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
	class Program
	{
		static void Main(string[] args)
		{
			var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
			string input = Console.ReadLine();

			while (input != "Statistics")
			{
				string[] splittedInput = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				string vloggerName = splittedInput[0];
				string command = splittedInput[1];

				if (command == "joined")
				{
					if (!vloggers.ContainsKey(vloggerName))
					{
						vloggers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
						vloggers[vloggerName].Add("followers", new HashSet<string>());
						vloggers[vloggerName].Add("following", new HashSet<string>());
					}
				}
				else if (command == "followed")
				{
					string followedVloger = splittedInput[2];

					if (vloggers.ContainsKey(followedVloger)
						&& vloggers.ContainsKey(vloggerName)
						&& followedVloger != vloggerName)
					{
						vloggers[vloggerName]["following"].Add(followedVloger);
						vloggers[followedVloger]["followers"].Add(vloggerName);
					}
				}

				input = Console.ReadLine();
			}

			int vloggersCount = vloggers.Keys.Count;
			Console.WriteLine($"The V-Logger has a total of {vloggersCount} vloggers in its logs.");
			vloggers = vloggers
				.OrderByDescending(x => x.Value["followers"].Count)
				.ThenBy(x => x.Value["following"].Count)
				.ToDictionary(x => x.Key, y => y.Value);

			int number = 1;

			foreach (var vlogger in vloggers)
			{
				string vloggerName = vlogger.Key;
				int followersCount = vlogger.Value["followers"].Count;
				int followingCount = vlogger.Value["following"].Count;
				Console.WriteLine($"{number}. {vloggerName} : {followersCount} followers, {followingCount} following");

				if (number == 1)
				{
					foreach (string follower in vlogger.Value["followers"].OrderBy(x => x))
					{
						Console.WriteLine($"*  {follower}");
					}
				}

				number++;
			}
		}
	}
}
