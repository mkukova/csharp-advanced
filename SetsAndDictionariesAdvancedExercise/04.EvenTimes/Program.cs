﻿using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberCount = int.Parse(Console.ReadLine());
			var numbers = new Dictionary<int, int>();

			for (int i = 0; i < numberCount; i++)
			{
				int number = int.Parse(Console.ReadLine());

				if (!numbers.ContainsKey(number))
				{
					numbers[number] = 0;
				}

				numbers[number]++;
			}

			foreach (var number in numbers)
			{
				if (number.Value % 2 == 0)
				{
					Console.WriteLine(number.Key);
					break;
				}
			}
		}
	}
}
