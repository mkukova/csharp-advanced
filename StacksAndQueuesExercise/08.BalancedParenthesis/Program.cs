﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
	class Program
	{
		static void Main(string[] args)
		{
			var parenthesis = new Stack<char>();
			char[] input = Console.ReadLine()
				.ToCharArray();
			var openParenthesis = new char[]
			{
				'{',
				'[',
				'('
			};

			bool isValid = true;

			foreach (char item in input)
			{
				if (openParenthesis.Contains(item))
				{
					parenthesis.Push(item);
					continue;
				}

				if (parenthesis.Count == 0)
				{
					isValid = false;
					break;
				}

				if (parenthesis.Peek() == '(' && item == ')')
				{
					parenthesis.Pop();
				}
				else if (parenthesis.Peek() == '{' && item == '}')
				{
					parenthesis.Pop();
				}
				else if (parenthesis.Peek() == '[' && item == ']')
				{
					parenthesis.Pop();
				}
				else
				{
					isValid = false;
					break;
				}
			}

			if (isValid)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}
