//#define WRITE_TO_FILE
#define READ_FROM_FILE
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
#if WRITE_TO_FILE
			string currentDirectory = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(currentDirectory);
			//SreamWriter - поток записи в файл
			//StreamReader - поток чтения из файла
			StreamWriter sw = new StreamWriter(filename, true);
			sw.WriteLine("Hello");
			sw.Close();
			Console.WriteLine(currentDirectory);
			Console.WriteLine(filename);
			string cmd = currentDirectory + "\\" + filename;
			Console.WriteLine(cmd);
			System.Diagnostics.Process.Start("notepad", cmd); 
			sw.Close();
#endif


#if READ_FROM_FILE
			string currentDirectory = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(currentDirectory);


			StreamReader sr = new StreamReader(filename);
			for (int i = 1; !sr.EndOfStream; i++)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(i + " " + buffer);
			}
			sr.Close();
#endif
		}
	}
}
