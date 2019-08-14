using System;
using System.Collections.Generic;

namespace _1.ReverseStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<char> result = new Stack<char>(input);

			while (result.Count != 0)
			{
				Console.Write(result.Pop());
			}
		}
	}
}
