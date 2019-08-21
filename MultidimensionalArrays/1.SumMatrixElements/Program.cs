using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.SumMatrixElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[,] arr = new int[dimensions[0], dimensions[1]];
			int sum = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				int[] tokens = Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = tokens[j];
					sum += arr[i, j];
				}
			}

			Console.WriteLine(arr.GetLength(0));
			Console.WriteLine(arr.GetLength(1));
			Console.WriteLine(sum);
		}
	}
}
