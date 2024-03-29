﻿using System;
using System.Linq;

namespace _7.PascalTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			long[][] jaggedArr = new long[size][];
			int cols = 1;

			for (int i = 0; i < size; i++)
			{
				jaggedArr[i] = new long[cols];
				jaggedArr[i][0] = 1;
				jaggedArr[i][cols - 1] = 1;

				if (cols > 2)
				{
					long[] previousRow = jaggedArr[i - 1];

					for (int j = 1; j < cols - 1; j++)
					{
						jaggedArr[i][j] = previousRow[j] + previousRow[j - 1];
					}
				}

				cols++;
			}

			foreach (long[] row in jaggedArr)
			{
				Console.WriteLine(string.Join(" ", row));
			}
		}
	}
}
