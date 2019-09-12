using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.Reverse()
				.ToList();

			int divider = int.Parse(Console.ReadLine());

			Predicate<int> divisible = num
				=> num % divider == 0 ? true : false;

			List<int> resultNumbers = numbers.FindAll(x => !divisible(x));
			Console.WriteLine(string.Join(" ", resultNumbers));
		}
	}
}
