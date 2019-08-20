using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MaximumAndMinimumElement
{
	class Program
	{
		static void Main(string[] args)
		{
			string countAsString = Console.ReadLine();
			int count = int.Parse(countAsString);
			var stack = new Stack<int>();

			for (int i = 0; i < count; i++)
			{
				int[] input = Console.ReadLine()
					.Split(" ")
					.Select(int.Parse)
					.ToArray();

				switch (input[0])
				{
					case 1:
						{
							int numberToPush = input[1];
							stack.Push(numberToPush);
							break;
						}

					case 2:
						{
							if (stack.Any())
							{
								stack.Pop();
							}

							break;
						}

					case 3:
						{
							if (stack.Any())
							{
								int maxElement = stack.Max();
								Console.WriteLine(maxElement);
							}

							break;
						}

					case 4:
						{
							if (stack.Any())
							{
								int minElement = stack.Min();
								Console.WriteLine(minElement);
							}

							break;
						}

					default:
						Console.WriteLine("Incorrect command!");
						break;
				}
			}

			string output = string.Join(", ", stack);
			Console.WriteLine(output);
		}
	}
}
