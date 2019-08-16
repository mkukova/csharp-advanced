using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MaximumAndMinimumElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberLines = int.Parse(Console.ReadLine());
			var stack = new Stack<int>();

			for (int i = 0; i < numberLines; i++)
			{
				int[] input = Console.ReadLine()
					.Split(" ")
					.Select(int.Parse)
					.ToArray();

				switch (input[0])
				{
					case 1:
						stack.Push(input[1]);
						break;
					case 2:
						if (stack.Any())
						{
							stack.Pop();
						}

						break;
					case 3:
						if (stack.Any())
						{
							Console.WriteLine(stack.Max());
						}

						break;
					case 4:
						if (stack.Any())
						{
							Console.WriteLine(stack.Min());
						}

						break;
					default:
						Console.WriteLine("Incorrect command!");
						break;
				}
			}

			Console.WriteLine(string.Join(", ", stack));
		}
	}
}
