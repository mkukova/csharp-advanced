using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			var usernames = new HashSet<string>();

			for (int i = 0; i < count; i++)
			{
				string name = Console.ReadLine();
				usernames.Add(name);
			}

			foreach (string username in usernames)
			{
				Console.WriteLine(username);
			}
		}
	}
}
