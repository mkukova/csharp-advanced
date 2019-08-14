using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.HotPotato
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			int count = int.Parse(Console.ReadLine());
			Queue<string> children = new Queue<string>(input);

			while (children.Count != 1)
			{
				for (int i = 1; i < count; i++)
				{
					string currentPlayer = children.Dequeue();
					children.Enqueue(currentPlayer);
				}

				Console.WriteLine($"Removed {children.Dequeue()}");
			}

			Console.WriteLine($"Last is {children.Dequeue()}");

		}
	}
}
