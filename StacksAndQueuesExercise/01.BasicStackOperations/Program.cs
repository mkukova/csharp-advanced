using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.BasicStackOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			int numberElementsToPush = input[0];
			int numberElementsToPop = input[1];
			int searchedElement = input[2];

			int[] numbers = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			Stack<int> result = new Stack<int>();

			for (int i = 0; i < numberElementsToPush; i++)
			{
				result.Push(numbers[i]);
			}

			for (int i = 0; i < numberElementsToPop; i++)
			{
				if (!result.Any())
				{
					break;
				}

				result.Pop();
			}

			if (result.Contains(searchedElement))
			{
				Console.WriteLine("true");
			}
			else if (result.Any())
			{
				Console.WriteLine(result.Min());
			}
			else
			{
				Console.WriteLine(0);
			}
		}
	}
}
