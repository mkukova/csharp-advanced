using System;
using System.IO;

namespace _04.CopyBinaryFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string picPath = @"copyMe.png";
			string picCopyPath = @"copyMe-copy.png";
			FileStream streamReader = new FileStream(picPath, FileMode.Open);

			using (streamReader)
			{
				FileStream writer = new FileStream(picCopyPath, FileMode.Create);

				using (writer)
				{
					while (true)
					{
						var byteArray = new byte[4096];
						int size = streamReader.Read(byteArray, 0, byteArray.Length);

						if (size == 0)
						{
							break;
						}

						writer.Write(byteArray, 0, size);
					}
				}
			}
		}
	}
}
