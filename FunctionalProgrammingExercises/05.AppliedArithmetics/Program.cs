﻿using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputNumbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			Func<int, int> incrementByOne = x => x += 1;
			Func<int, int> multiply = x => x *= 2;
			Func<int, int> subtractByOne = x => x -= 1;
			Action<int[]> print = numbers
				=> Console.WriteLine(string.Join(" ", numbers));
			string command = Console.ReadLine().ToLower();

			while (command != "end")
			{
				if (command == "add")
				{
					inputNumbers = inputNumbers
						.Select(incrementByOne)
						.ToArray();
				}
				else if (command == "multiply")
				{
					inputNumbers = inputNumbers
						.Select(multiply)
						.ToArray();
				}
				else if (command == "subtract")
				{
					inputNumbers = inputNumbers
						.Select(subtractByOne)
						.ToArray();
				}
				else if (command == "print")
				{
					print(inputNumbers);
				}

				command = Console.ReadLine().ToLower();
			}
		}
	}
}
