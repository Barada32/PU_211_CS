using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace Introduction
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Привет Дотнет";
			//Console.WriteLine("\t\t\tHello \"World\"");

			#region CONSOLE
			/*Console.BackgroundColor = ConsoleColor.Blue;
			Console.CursorLeft = 22;
			Console.CursorTop = 12;
			Console.Write("Привет дотнет))\n");

			Console.BackgroundColor = System.ConsoleColor.Green;
			Console.CursorLeft = 32;
			Console.CursorTop = 5;
			Console.Write("Привет дотнет))\n");
			Console.BackgroundColor = ConsoleColor.Black;

			Console.Beep(44, 2000);*/
			#endregion CONSOLE

			//			Object
			//Valuable
			//Referenced

			#region STRING_OPERATIONS
			/*
			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			string s_age = Console.ReadLine();
			int age = Convert.ToInt32(s_age);

			Console.WriteLine("Фамилия " + last_name + " имя " + first_name + " возраст " + age + " лет.");//Конкатенация строк
			Console.WriteLine(String.Format("Фамилия {0} имя {1} возраст {2} лет.", last_name, first_name, age));//Форматирование строк
			Console.WriteLine($"Фамилия {last_name} имя {first_name} возраст {age} лет.");//Интерполяция строк.
			*/
			#endregion

			#region DATA_TYPES
			/*
			Console.WriteLine("BOOL:");
			Console.WriteLine(sizeof(bool));
			Console.WriteLine("CHAR:");
			Console.WriteLine(sizeof(char));//Unicode (UTF-16)
			Console.WriteLine(Convert.ToInt32(Char.MinValue));
			Console.WriteLine(Convert.ToInt32(Char.MaxValue));
			Console.WriteLine(" ----------------- NUMERIC TYPES ----------------- ");
			Console.WriteLine("SHORT:");
			short a = 2;
			ushort b = 3;
			Console.WriteLine(sizeof(short));
			Console.WriteLine(short.MinValue + "..." + short.MaxValue);
			Console.WriteLine($"Переменная типа short занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне от {short.MinValue} до {short.MaxValue}");
			*/
			#endregion DATA_TYPES

			#region TYPE_CONVERSIONS
			/*
			int a = 2;
			uint b = 3;
			a = (int)b;
			double c = 5.2;
			a = (int)c;
			bool day = true;
			Console.WriteLine(Convert.ToInt32(day));
			double d = a;
			*/
			#endregion TYPE_CONVERSIONS

			#region LITHERALS
			/*
			Console.WriteLine((-5l).GetType());
			Console.WriteLine((5.0f).GetType());
			Console.WriteLine((5.0m).GetType());
			Console.WriteLine(3e-500);
			Console.WriteLine(sizeof(decimal));

			decimal dividend = Decimal.One;
			decimal divisor = 3;
			// The following displays 0.9999999999999999999999999999 to the console
			Console.WriteLine(Math.Round(dividend / divisor * divisor));
			*/
			#endregion LITERALS

			int i = 3;

			i = ++i + ++i;

			Console.WriteLine(i);
		}
	}
}
