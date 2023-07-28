using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
	class Program
	{
		static void Main(string[] args)
		{
			//SreamWriter  - поток записи в файл
			//StreamReader - поток чтения из файла
			StreamWriter sw = new StreamWriter("File.txt");
			sw.Write("Hello");
			sw.Close();
		}
	}
}
