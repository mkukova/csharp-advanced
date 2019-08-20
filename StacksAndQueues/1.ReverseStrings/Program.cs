using System;
using System.Collections.Generic;

namespace _1.ReverseStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var result = new Stack<char>(input);

			while (result.Count != 0)
			{
				char output = result.Pop();
				Console.Write(output);
			}
		}
	}
}
