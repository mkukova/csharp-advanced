using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.BasicQueueOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			int[] numbers = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			var resultNumbers = new Queue<int>();

			for (int i = 0; i < input[0]; i++)
			{
				resultNumbers.Enqueue(numbers[i]);
			}

			for (int i = 0; i < Math.Min(input[0], input[1]); i++)
			{
				resultNumbers.Dequeue();
			}

			if (!resultNumbers.Any())
			{
				Console.WriteLine(0);
			}
			else if (!resultNumbers.Contains(input[2]))
			{
				Console.WriteLine(resultNumbers.Min());
			}
			else
			{
				Console.WriteLine("true");
			}
		}
	}
}
