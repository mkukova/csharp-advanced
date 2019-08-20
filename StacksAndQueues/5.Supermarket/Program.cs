using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Supermarket
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var queue = new Queue<string>();

			while (input != "End")
			{
				if (input == "Paid")
				{
					while (queue.Count > 0)
					{
						string dequeuedPerson = queue.Dequeue();
						Console.WriteLine(dequeuedPerson);
					}
				}
				else
				{
					queue.Enqueue(input);
				}

				input = Console.ReadLine();
			}

			int remainingPeople = queue.Count;
			Console.WriteLine($"{remainingPeople} people remaining.");
		}
	}
}
