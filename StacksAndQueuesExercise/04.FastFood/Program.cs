using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
	class Program
	{
		static void Main(string[] args)
		{
			string foodQuantityAsString = Console.ReadLine();
			int foodQuantity = int.Parse(foodQuantityAsString);
			int[] ordersQuantity = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			var queue = new Queue<int>(ordersQuantity);
			int maxElement = queue.Max();
			Console.WriteLine(maxElement);

			while (queue.Any())
			{
				int quantityToRemove = queue.Peek();

				if ((foodQuantity - quantityToRemove) >= 0)
				{
					foodQuantity -= quantityToRemove;
					queue.Dequeue();
				}
				else
				{
					break;
				}
			}

			if (queue.Any())
			{
				string leftOrders = string.Join(" ", queue);
				Console.WriteLine($"Orders left: {leftOrders}");
			}
			else
			{
				Console.WriteLine("Orders complete");
			}
		}
	}
}
