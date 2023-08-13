using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			Specialist tommi = new Specialist("Vercetti", "Tomas", 30, "Theft", "Vice", 98, 99, "How to make money", 12);
			Teacher diaz = new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20);

			Human[] group = new Human[]
				{
					new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 80, 95),
					new Teacher("White", "Walter", 50, "Chemistry", 20),
					new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg"),
					tommi, diaz
				};
			for (int i = 0; i < group.Length; i++)
			{
				//Console.WriteLine(group[i]);
				group[i].Print();
				Console.WriteLine(delimiter);
			}

			//sealed - запечатанный
		}
	}
}
