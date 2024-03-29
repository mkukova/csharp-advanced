﻿using System;
using System.Linq;

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

			int rowCount = arr.GetLength(0);
			int colCount = arr.GetLength(1);

			Console.WriteLine(rowCount);
			Console.WriteLine(colCount);
			Console.WriteLine(sum);
		}
	}
}
