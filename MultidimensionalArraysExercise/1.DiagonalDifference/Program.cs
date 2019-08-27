using System;
using System.Linq;

namespace _1.DiagonalDifference
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[,] matrix = new int[size, size];

			for (int i = 0; i < size; i++)
			{
				int[] currentRow = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				for (int j = 0; j < size; j++)
				{
					matrix[i, j] = currentRow[j];
				}
			}

			int sumPrimaryDiagonal = 0;
			int sumSecondaryDiagonal = 0;
			int counter = size - 1;

			for (int i = 0; i < size; i++)
			{
				sumPrimaryDiagonal += matrix[i, i];
				sumSecondaryDiagonal += matrix[i, counter];
				counter--;
			}

			int difference = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
			Console.WriteLine(difference);
		}
	}
}
