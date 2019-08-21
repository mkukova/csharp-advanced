using System;
using System.Linq;

namespace _2.SumMatrixColumns
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
				.Split()
				.Select(int.Parse)
				.ToArray();

				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = tokens[j];
				}
			}

			int sum = 0;

			for (int col = 0; col < matrix.GetLength(1); col++)
			{
				sum = 0;

				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					sum += matrix[row, col];
				}

				Console.WriteLine(sum);
			}
		}
	}
}
