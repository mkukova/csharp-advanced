using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
	class Program
	{
		static void Main(string[] args)
		{
			int foodQuantity = int.Parse(Console.ReadLine());
			int[] ordersQuantity = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();
			var queue = new Queue<int>(ordersQuantity);
			Console.WriteLine(queue.Max());

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
				Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
			}
			else 
			{
				Console.WriteLine("Orders complete");
			}
		}
	}
}
