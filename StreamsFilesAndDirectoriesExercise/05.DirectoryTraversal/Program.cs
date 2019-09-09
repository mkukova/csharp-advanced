using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace _05.DirectoryTraversal
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] fileArray = Directory.GetFiles(".", "*.*");
			var dirInfo = new Dictionary<string, Dictionary<string, double>>();
			var directoryInfo = new DirectoryInfo(".");
			FileInfo[] allFiles = directoryInfo.GetFiles();

			foreach (FileInfo currentFile in allFiles)
			{
				double size = currentFile.Length / 1024d;
				string fileName = currentFile.Name;
				string extension = currentFile.Extension;

				if (!dirInfo.ContainsKey(extension))
				{
					dirInfo.Add(extension, new Dictionary<string, double>());
				}

				if (!dirInfo[extension].ContainsKey(fileName))
				{
					dirInfo[extension].Add(fileName, size);
				}
			}

			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";
			var sortedDictionary = dirInfo
				.OrderByDescending(x => x.Value.Count)
				.ThenBy(x => x.Key)
				.ToDictionary(x => x.Key, y => y.Value);


			foreach ((string extension, Dictionary<string, double> value) in sortedDictionary)
			{
				File.AppendAllText(path, extension);

				foreach ((string fileName, double size) in value.OrderBy(x => x.Value))
				{
					File.AppendAllText(path, $"--{fileName} - {size:F3}kb {Environment.NewLine}");
				}
			}
		}
	}
}
