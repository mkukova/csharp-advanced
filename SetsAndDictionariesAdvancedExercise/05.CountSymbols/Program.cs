using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
	class Program
	{
		static void Main(string[] args)
		{
			var symbols = new SortedDictionary<char, int>();
			string input = Console.ReadLine();

			for (int i = 0; i < input.Length; i++)
			{
				char currentSymbol = input[i];

				if (!symbols.ContainsKey(currentSymbol))
				{
					symbols[currentSymbol] = 0;
				}

				symbols[currentSymbol]++;
			}

			foreach (var symbol in symbols)
			{
				Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
			}
		}
	}
}
