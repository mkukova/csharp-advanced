using System;
using System.Linq;

namespace _3.MaximalSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[,] matrix = new int[size[0], size[1]];

			for (int i = 0; i < size[0]; i++)
			{
				int[] currentRow = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

				for (int j = 0; j < size[1]; j++)
				{
					matrix[i, j] = currentRow[j];
				}
			}

			int maxSum = int.MinValue;
			int row = -1;
			int col = -1;

			for (int i = 0; i < size[0] - 2; i++)
			{
				for (int j = 0; j < size[1] - 2; j++)
				{
					int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
						+ matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
						+ matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

					if (currentSum > maxSum)
					{
						maxSum = currentSum;
						row = i;
						col = j;
					}
				}
			}

			Console.WriteLine($"Sum = {maxSum}");
			Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}\n" +
				$"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}\n" +
	$"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
		}
	}
}
