using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToArray();

			var count = new Dictionary<double, int>();

			foreach (double number in numbers)
			{
				if (count.ContainsKey(number))
				{
					count[number]++;
				}
				else
				{
					count[number] = 1;
				}
			}

			foreach (var kvp in count)
			{
				Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
			}
		}
	}
}
