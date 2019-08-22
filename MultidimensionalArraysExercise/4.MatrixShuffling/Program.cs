using System;
using System.Linq;

namespace _4.MatrixShuffling
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(" ")
				.Select(int.Parse)
				.ToArray();

			string[,] matrix = new string[size[0], size[1]];

			for (int i = 0; i < size[0]; i++)
			{
				string[] currentRow = Console.ReadLine()
					.Split(" ");

				for (int j = 0; j < size[1]; j++)
				{
					matrix[i, j] = currentRow[j];
				}
			}

			string command = Console.ReadLine();
			bool isValidCommand = true;

			while (command != "END")
			{
				if (!isValidCommand)
				{
					Console.WriteLine("Invalid input!");
					command = Console.ReadLine();
					isValidCommand = true;
					continue;
				}

				if (!command.Contains("swap"))
				{
					isValidCommand = false;
					continue;
				}

				string[] splittedCommand = command
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				int splittedCommandLenght = splittedCommand.Count();

				if (splittedCommandLenght != 5)
				{
					isValidCommand = false;
					continue;
				}

				int row1 = int.Parse(splittedCommand[1]);
				int col1 = int.Parse(splittedCommand[2]);
				int row2 = int.Parse(splittedCommand[3]);
				int col2 = int.Parse(splittedCommand[4]);

				if (row1 >= size[0] || row2 >= size[0]
					|| col1 >= size[1] || col2 >= size[1])
				{
					isValidCommand = false;
					continue;
				}

				string infoToSwap = matrix[row1, col1];
				matrix[row1, col1] = matrix[row2, col2];
				matrix[row2, col2] = infoToSwap;

				for (int i = 0; i < size[0]; i++)
				{
					for (int j = 0; j < size[1]; j++)
					{
						Console.Write($"{matrix[i, j]} ");
					}
					Console.WriteLine();
				}

				command = Console.ReadLine();
			}
		}
	}
}
