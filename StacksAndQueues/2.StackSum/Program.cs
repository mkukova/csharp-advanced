using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
	class Program
	{
		static void Main()
		{
			int[] numbers = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			string command = Console.ReadLine().ToLower();
			Stack<int> result = new Stack<int>(numbers);

			while (command != "end")
			{
				string[] input = command.Split();

				if (input[0].ToLower() == "add")
				{
					int firstNumber = int.Parse(input[1]);
					int seconfNumber = int.Parse(input[2]);
					result.Push(firstNumber);
					result.Push(seconfNumber);
				}
				else if (input[0].ToLower() == "remove")
				{
					int number = int.Parse(input[1]);
					if (result.Count >= number)
					{
						for (int i = 0; i < number; i++)
						{
							result.Pop();
						}
					}
				}

				command = Console.ReadLine().ToLower();
			}

			Console.WriteLine($"Sum: {result.Sum()}");
		}
	}
}
