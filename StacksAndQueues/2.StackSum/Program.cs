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
			string command = Console.ReadLine()
				.ToLower();
			var result = new Stack<int>(numbers);

			while (command != "end")
			{
				string[] input = command.Split();
				string operation = input[0].ToLower();

				if (operation == "add")
				{
					int firstNumber = int.Parse(input[1]);
					int seconfNumber = int.Parse(input[2]);
					result.Push(firstNumber);
					result.Push(seconfNumber);
				}
				else if (operation == "remove")
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

			int sum = result.Sum();
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
