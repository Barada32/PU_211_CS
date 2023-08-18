//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
	class Program
	{
		const string delimiter = "\n----------------------------------\n";
		static void Main(string[] args)
		{
			#region INHERITANCE
			/*Human human = new Human("Montana", "Antonio", 25);
				Console.WriteLine(human);

				Student pinkman = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 80, 95);
				Console.WriteLine(pinkman);

				Teacher whaite = new Teacher("White", "Walter", 50, "Chemistry", 20);
				Console.WriteLine(whaite);

				Graduate hank = new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg");
				Console.WriteLine(hank);*/
			#endregion

#if WRITE_TO_FILE
			Specialist tommi = new Specialist("Vercetti", "Tomas", 30, "Theft", "Vice", 98, 99, "How to make money", 12);
			Teacher diaz = new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20);

			Human[] group = new Human[]
				{
					new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 80, 95),
					new Teacher("White", "Walter", 50, "Chemistry", 20),
					new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg"),
					tommi, diaz
				};

			string currentDirectory = Directory.GetCurrentDirectory();
			string filename = "group.txt";

			StreamWriter streamWriter = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
				streamWriter.WriteLine(group[i]+";");
				//group[i].Print();
				Console.WriteLine(delimiter);
			}
			streamWriter.Close();
			//sealed - запечатанный

			string cmd = currentDirectory + "\\" + filename;
			System.Diagnostics.Process.Start("notepad", cmd); 
#endif

			Load("group.txt");
			//Console.WriteLine(typeof(Academy.Student).ToString());
		}
		static Human[] Load(string filename)
		{
			Human[] group = null;
			List<Human> l_group = new List<Human>();
			StreamReader streamReader = new StreamReader(filename);
			while (!streamReader.EndOfStream)
			{
				string buffer = streamReader.ReadLine();
				string[] values = buffer.Split(new char[] { ':', ',', ';' });
				#region READ_CHECK
				//Console.WriteLine(buffer);
				//foreach (string i in values) Console.Write(i + "\t");
				//Console.WriteLine();
				//Console.WriteLine(delimiter);
				//Console.WriteLine(); 
				#endregion
				l_group.Add(HumanFactory(values[0]));
				//Console.WriteLine(l_group.Last().GetType());
				l_group.Last();
			}
			streamReader.Close();
			return group;
		}
		static Human HumanFactory(string type)
		{
			Human human = null;
			if (type == typeof(Academy.Student).ToString())		human = new Student("", "", 0, "", "", 0, 0);
			if (type == typeof(Academy.Teacher).ToString())		human = new Teacher("", "", 0, "", 0);
			if (type == typeof(Academy.Graduate).ToString())	human = new Graduate("", "", 0, "", "", 0, 0, "");
			if (type == typeof(Academy.Specialist).ToString())	human = new Specialist("", "", 0, "", "", 0, 0, "", 0);
			return human;
		}
		static Human InitHuman(Human obj, string[] values)
		{
			if (obj.GetType() == typeof(Academy.Student))
			{

			}
			return obj;
		}
	}
}
