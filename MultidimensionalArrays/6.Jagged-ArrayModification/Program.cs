using System;
using System.Linq;

namespace _6.Jagged_ArrayModification
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int[][] jaggedArray = new int[rows][];

			for (int i = 0; i < rows; i++)
			{
				int[] numbers = Console.ReadLine()
					.Split(" ")
					.Select(int.Parse)
					.ToArray();

				jaggedArray[i] = numbers;
			}

			string command = Console.ReadLine();

			while (command != "END")
			{
				string[] tokens = command
					.Split(" ");

				string operation = tokens[0];
				int row = int.Parse(tokens[1]);
				int col = int.Parse(tokens[2]);
				int value = int.Parse(tokens[3]);

				if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
				{
					Console.WriteLine("Invalid coordinates");
					command = Console.ReadLine();
					continue;
				}

				switch (operation)
				{
					case "Add":
						{
							jaggedArray[row][col] += value;
							break;
						}

					case "Subtract":
						{
							jaggedArray[row][col] -= value;
							break;
						}

					default:
						Console.WriteLine("Incorect operation");
						break;

				}

				command = Console.ReadLine();
			}

			foreach (int[] row in jaggedArray)
			{
				Console.WriteLine(string.Join(" ", row));
			}
		}
	}
}
