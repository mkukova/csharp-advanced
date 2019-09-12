using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.PredicateForNames
{
	class Program
	{
		static void Main(string[] args)
		{
			int nameLength = int.Parse(Console.ReadLine());
			List<string> names = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			Predicate<string> isValidName = name
				=> name.Length <= nameLength;

			List<string> validNames = names.FindAll(isValidName);
			Console.WriteLine(string.Join(Environment.NewLine, validNames));
		}
	}
}
