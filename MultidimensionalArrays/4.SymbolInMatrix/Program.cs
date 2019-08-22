using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			char[,] matrix = new char[size, size];

			for (int i = 0; i < size; i++)
			{
				string tokens = Console.ReadLine();

				for (int j = 0; j < size; j++)
				{
					matrix[i, j] = tokens[j];
				}
			}

			char searchedSymbol = char.Parse(Console.ReadLine());
			int row = -1;
			int col = -1;

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (matrix[i, j] != searchedSymbol)
					{
						continue;
					}

					row = i;
					col = j;
					break;
				}
			}

			if (row != -1 && col != -1)
			{
				Console.WriteLine($"({row}, {col})");
			}
			else
			{
				Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
			}
		}
	}
}
