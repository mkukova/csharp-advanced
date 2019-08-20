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
			string countAsString = Console.ReadLine();
			int count = int.Parse(countAsString);
			var children = new Queue<string>(input);

			while (children.Count != 1)
			{
				for (int i = 1; i < count; i++)
				{
					string currentPlayer = children.Dequeue();
					children.Enqueue(currentPlayer);
				}

				string removedChild = children.Dequeue();
				Console.WriteLine($"Removed {removedChild}");
			}

			string lastChild = children.Dequeue();
			Console.WriteLine($"Last is {lastChild}");
		}
	}
}
