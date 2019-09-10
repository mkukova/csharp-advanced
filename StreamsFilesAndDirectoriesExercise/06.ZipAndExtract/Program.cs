using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
	class Program
	{
		static void Main(string[] args)
		{
			string zipFile = @"..\..\..\myNewZip.zip";
			string file = "copyMe.png";
			ZipArchive archive = ZipFile.Open(zipFile, ZipArchiveMode.Create);

			using (archive)
			{
				archive.CreateEntryFromFile(file, Path.GetFileName(file));
			}
		}
	}
}
