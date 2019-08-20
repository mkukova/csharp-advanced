using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			IEnumerable<string> reversedInput = input.Reverse();
			var expression = new Stack<string>(reversedInput);

			while (expression.Count != 1)
			{
				string firstNumberAsString = expression.Pop();
				int firstNumber = int.Parse(firstNumberAsString);
				string operatorr = expression.Pop();
				string secondNumberAsString = expression.Pop();
				int secondNumber = int.Parse(secondNumberAsString);
				int result = 0;
				string resultAsString = "";

				if (operatorr == "+")
				{
					result = firstNumber + secondNumber;
					resultAsString = result.ToString();
					expression.Push(resultAsString);
				}
				else if (operatorr == "-")
				{
					result = firstNumber - secondNumber;
					resultAsString = result.ToString();
					expression.Push(resultAsString);
				}
			}

			Console.WriteLine(expression.Pop());
		}
	}
}
