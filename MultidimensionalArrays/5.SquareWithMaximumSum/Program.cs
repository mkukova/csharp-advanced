using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[,] matrix = new int[size[0], size[1]];

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				int[] tokens = Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = tokens[j];
				}
			}

			int maxSum = int.MinValue;
			int selectedRow = -1;
			int selectedCol = -1;

			for (int row = 0; row < matrix.GetLength(0) - 1; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 1; col++)
				{
					int sum = matrix[row, col] + matrix[row, col + 1]
						+ matrix[row + 1, col] + matrix[row + 1, col + 1];

					if (sum > maxSum)
					{
						maxSum = sum;
						selectedCol = col;
						selectedRow = row;
					}
				}
			}

			for (int i = selectedRow; i < selectedRow + 2; i++)
			{
				for (int y = selectedCol; y < selectedCol + 2; y++)
				{
					Console.Write($"{matrix[i, y]} ");
				}

				Console.WriteLine();
			}

			Console.WriteLine(maxSum);
		}
	}
}
