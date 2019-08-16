using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<char> parenthesis = new Stack<char>();
			char[] input = Console.ReadLine().ToCharArray();
			char[] openParenthesis = new char[] { '{', '[', '(' };
			foreach (var item in input)
			{
				if (openParenthesis.Contains(item))
				{
					parenthesis.Push(item);
				}

				if (parenthesis.Peek() == '(' && item == ')')
				{

				}
			}
		}
	}
}
