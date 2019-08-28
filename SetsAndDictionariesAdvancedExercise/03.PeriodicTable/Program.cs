using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputLinesCount = int.Parse(Console.ReadLine());
			var elements = new HashSet<string>();

			for (int i = 0; i < inputLinesCount; i++)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				for (int j = 0; j < input.Length; j++)
				{
					string currentElement = input[j];
					elements.Add(currentElement);
				}
			}

			elements = elements.OrderBy(x => x).ToHashSet();
			string result = string.Join(" ", elements);
			Console.WriteLine(result);
		}
	}
}
