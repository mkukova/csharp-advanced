using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.SetsOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] setsLenght = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int firstSetLenght = setsLenght[0];
			int secondSetLenght = setsLenght[1];
			var firstSet = new HashSet<int>();
			var secondSet = new HashSet<int>();

			for (int i = 0; i < firstSetLenght; i++)
			{
				int number = int.Parse(Console.ReadLine());
				firstSet.Add(number);
			}

			for (int i = 0; i < secondSetLenght; i++)
			{
				int number = int.Parse(Console.ReadLine());
				secondSet.Add(number);
			}

			foreach (int number in firstSet)
			{
				if (secondSet.Contains(number))
				{
					Console.Write($"{number} ");
				}
			}
		}
	}
}
