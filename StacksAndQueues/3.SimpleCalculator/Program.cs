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
			Stack<string> expression = new Stack<string>(input.Reverse());

			while (expression.Count != 1)
			{
				int firstNumber = int.Parse(expression.Pop());
				string operatorr = expression.Pop();
				int secondNumber = int.Parse(expression.Pop());
				int result = 0;

				if (operatorr == "+")
				{
					result = firstNumber + secondNumber;
					expression.Push(result.ToString());
				}
				else if (operatorr == "-")
				{
					result = firstNumber - secondNumber;
					expression.Push(result.ToString());
				}
			}

			Console.WriteLine(expression.Pop());
		}
	}
}
