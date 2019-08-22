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
			bool isFound = false;

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (matrix[i, j] == searchedSymbol)
					{
						Console.WriteLine($"({i}, {j})");
						isFound = true;
						break;
					}
				}

				if (isFound)
				{
					break;
				}
			}

			if (!isFound)
			{
				Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
			}
		}
	}
}
