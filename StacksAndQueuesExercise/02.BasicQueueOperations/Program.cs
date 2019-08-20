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
				int currentNumber = numbers[i];
				resultNumbers.Enqueue(currentNumber);
			}

			int numberToEnqueue = input[0];
			int numberToDequeue = input[1];
			int dequeueCount = Math.Min(numberToEnqueue, numberToDequeue);

			for (int i = 0; i < dequeueCount; i++)
			{
				resultNumbers.Dequeue();
			}

			int searchedNumber = input[2];

			if (!resultNumbers.Any())
			{
				Console.WriteLine(0);
			}
			else if (!resultNumbers.Contains(searchedNumber))
			{
				int minNumber = resultNumbers.Min();
				Console.WriteLine(minNumber);
			}
			else
			{
				Console.WriteLine("true");
			}
		}
	}
}
