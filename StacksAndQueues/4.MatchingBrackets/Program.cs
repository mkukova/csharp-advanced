using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var stack = new Stack<int>();
			int inputLenght = input.Length;

			for (int i = 0; i < inputLenght; i++)
			{
				char currentSymbol = input[i];

				if (currentSymbol == '(')
				{
					stack.Push(i);
				}
				else if (currentSymbol == ')')
				{
					int startIndex = stack.Pop();
					int substringLenght = i - startIndex + 1;
					string contents = input.Substring(startIndex, substringLenght);
					Console.WriteLine(contents);
				}
			}
		}
	}
}
