using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] cupsCapacity = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			int[] bottles = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			var bottlesStack = new Stack<int>(bottles);
			var cupsQueue = new Queue<int>(cupsCapacity);
			int wastedWater = 0;

			while (cupsQueue.Any() && bottlesStack.Any())
			{
				int currentCup = cupsQueue.Peek();

				while (currentCup != 0 && bottlesStack.Any())
				{
					int currentBottle = bottlesStack.Pop();

					if (currentBottle - currentCup >= 0)
					{
						wastedWater += (currentBottle - currentCup);
						currentCup = 0;
						continue;
					}

					currentCup -= currentBottle;
				}

				cupsQueue.Dequeue();
			}

			if (bottlesStack.Any())
			{
				string remainingBottles = string.Join(" ", bottlesStack);
				Console.WriteLine($"Bottles: {remainingBottles}");
			}
			else
			{
				string remainingCups = string.Join(" ", cupsQueue);
				Console.WriteLine($"Cups: {remainingCups}");
			}

			Console.WriteLine($"Wasted litters of water: {wastedWater}");
		}
	}
}
