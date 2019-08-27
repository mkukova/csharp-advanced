using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
	class Program
	{
		static void Main(string[] args)
		{
			int studentsCount = int.Parse(Console.ReadLine());
			var students = new Dictionary<string, List<double>>();

			for (int i = 0; i < studentsCount; i++)
			{
				string[] currentStudentInfo = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				string name = currentStudentInfo[0];
				double grade = double.Parse(currentStudentInfo[1]);

				if (!students.ContainsKey(name))
				{
					students[name] = new List<double>();
				}

				students[name].Add(grade);
			}

			foreach (var kvp in students)
			{
				double averageGrade = kvp.Value.Average();
				Console.Write($"{kvp.Key} -> ");

				foreach (var grade in kvp.Value)
				{
					Console.Write($"{grade:f2} ");
				}

				Console.Write($"(avg: {averageGrade:f2})");
				Console.WriteLine();
			}
		}
	}
}
