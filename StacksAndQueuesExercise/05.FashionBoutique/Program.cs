using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] clothes = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			var stack = new Stack<int>(clothes);
			int rackCapacity = int.Parse(Console.ReadLine());
			int rackCounter = 0;

			while (stack.Any())
			{
				int sum = 0;

				while (sum != rackCapacity && stack.Any())
				{
					int currentClothe = stack.Peek();

					if ((sum + currentClothe) > rackCapacity)
					{
						break;
					}

					sum += currentClothe;
					stack.Pop();
				}

				rackCounter++;
			}

			Console.WriteLine(rackCounter);
		}
	}
}
