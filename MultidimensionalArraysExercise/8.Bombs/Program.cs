using System;
using System.Linq;

namespace _8.Bombs
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[,] matrix = new int[size, size];

			for (int row = 0; row < size; row++)
			{
				int[] currentRow = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				for (int col = 0; col < size; col++)
				{
					matrix[row, col] = currentRow[col];
				}
			}

			int[] coordinates = Console.ReadLine()
				.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			for (int i = 0; i < coordinates.Length; i += 2)
			{
				int currentRow = coordinates[i];
				int currentCol = coordinates[i + 1];
				int value = matrix[currentRow, currentCol];

				if (value < 0)
				{
					continue;
				}

				for (int row = currentRow - 1; row <= currentRow + 1; row++)
				{
					for (int col = currentCol - 1; col <= currentCol + 1; col++)
					{
						if (IsInside(matrix, row, col) && matrix[row, col] > 0)
						{
							matrix[row, col] -= value;
						}
					}
				}

				matrix[currentRow, currentCol] = 0;
			}

			int aliveCellsCount = 0;
			int aliveCellsSum = 0;

			for (int row = 0; row < size; row++)
			{
				for (int col = 0; col < size; col++)
				{
					if (matrix[row, col] > 0)
					{
						aliveCellsCount++;
						aliveCellsSum += matrix[row, col];
					}
				}
			}

			Console.WriteLine($"Alive cells: {aliveCellsCount}");
			Console.WriteLine($"Sum: {aliveCellsSum}");

			for (int i = 0; i < size; i++)
			{
				string[] result = new string[size];
				for (int j = 0; j < size; j++)
				{
					result[j] = matrix[i, j].ToString();
				}

				Console.WriteLine(string.Join(" ", result));
			}
		}
		static bool IsInside(int[,] matrix, int row, int col)
		{
			if (row < matrix.GetLength(0) && row >= 0
				&& col < matrix.GetLength(1) && col >= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
