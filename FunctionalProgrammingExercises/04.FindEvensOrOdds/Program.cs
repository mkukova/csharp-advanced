﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FindEvensOrOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] bounds = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int lowerBound = bounds[0];
			int upperBound = bounds[1];
			var numbers = new List<int>();
			string numberType = Console.ReadLine().ToLower();

			for (int i = lowerBound; i <= upperBound; i++)
			{
				numbers.Add(i);
			}

			Predicate<int> isEven = number => number % 2 == 0;
			Predicate<int> isOdd = number => number % 2 != 0;
			Action<List<int>> printNumbers = outputNumbers
				=> Console.WriteLine(string.Join(" ", outputNumbers));

			if (numberType == "odd")
			{
				numbers = numbers
					.Where(x => isOdd(x))
					.ToList();

			}
			else if (numberType == "even")
			{
				numbers = numbers
					.Where(x => isEven(x))
					.ToList();
			}

			printNumbers(numbers);
		}
	}
}
