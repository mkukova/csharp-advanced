using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int row = input[0];
			int col = input[1];

			var matrix = new int[row, col];
			var sum = new int[col];

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				int[] tokens = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();

				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = tokens[j];
					sum[j] += tokens[j];
				}
			}

			string result = string.Join(Environment.NewLine, sum);
			Console.WriteLine(result);
		}
	}
}
