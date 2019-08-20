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
			var clothesStack = new Stack<int>(clothes);
			string rackCapacityAsString = Console.ReadLine();
			int rackCapacity = int.Parse(rackCapacityAsString);
			int rackCounter = 0;

			while (clothesStack.Any())
			{
				int sum = 0;

				while (sum != rackCapacity && clothesStack.Any())
				{
					int currentClothe = clothesStack.Peek();

					if ((sum + currentClothe) > rackCapacity)
					{
						break;
					}

					sum += currentClothe;
					clothesStack.Pop();
				}

				rackCounter++;
			}

			Console.WriteLine(rackCounter);
		}
	}
}
