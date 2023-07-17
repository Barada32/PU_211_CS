using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLVL1
{
	class Program
	{
		static void Main(string[] args)
		{
			#region TASK_2
			//Console.WindowWidth = 120;
			//Console.WriteLine($"Тип данных 'short' занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне от {short.MinValue} до {short.MaxValue}");
			//Console.WriteLine($"Тип данных 'short' занимает {sizeof(int)} Байт памяти, и принимает значения в диапазоне от {int.MinValue} до {int.MaxValue}");
			#endregion

			#region TASK_3
			/*
				//double money;
				//int grn, cop;
				Console.Write("Введите сумму: ");
				decimal money = Convert.ToDecimal(Console.ReadLine());
				Console.WriteLine(money);
				int grn = (int)money;
				int cop = (int)((money - grn) * 100);
				Console.WriteLine($"{grn} грн. {cop} коп.");
				*/
			#endregion

			#region TASK_4
			/*Console.Write("Введите выражение: ");
				string expression = Console.ReadLine();		//Читает СТРОКУ с клавиатуры.
				expression = expression.Replace(',', '.');	//Replace(что заменить, чем заменить) заменяет первый символ вторым символом в строке
															//В данном случае заменяем ',' на '.'

				String[] values = expression.Split(new char[] { '+', '-', '*', '/' }, );
				//Метод Split()разделяет строку на подстроки, по указанным разделителям,
				//Scplit() принимает массив char, в котором перечислены разделители, 
				//и возвращает массив строк (токенов)
				//Метод Split() не изменяет исходную строку.

				for (int i = 0; i < values.Length; i++)
				{
					Console.WriteLine(values[i]);
				}
				double a = Convert.ToDouble(values[0]);
				double b = Convert.ToDouble(values[1]);
				//Метод Contains() проверяет, содержит ли исходная строка указанную подстроку.
				if (expression.Contains('+'))Console.WriteLine($"{a} + {b} = {a + b}");
				else if (expression.Contains("-"))Console.WriteLine($"{a} - {b} = {a - b}");
				else if (expression.Contains("*"))Console.WriteLine($"{a} * {b} = {a * b}");
				else if (expression.Contains("/"))Console.WriteLine($"{a} / {b} = {a / b}");
				else Console.WriteLine("No operation");*/
			#endregion

			#region SHOOTER
			//ConsoleKey key;
			//do
			//{
			//	key = Console.ReadKey(true).Key;
			//	switch (key)
			//	{
			//		case ConsoleKey.W: Console.WriteLine("Вперед"); break;
			//		case ConsoleKey.S: Console.WriteLine("Назад"); break;
			//		case ConsoleKey.A: Console.WriteLine("Влево"); break;
			//		case ConsoleKey.D: Console.WriteLine("Вправо"); break;
			//		case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
			//		case ConsoleKey.Enter: Console.Beep(); break;
			//		default: Console.WriteLine("Error"); break;
			//	}
			//} while (key != ConsoleKey.Escape); 
			#endregion

			Console.SetWindowPosition(0, 0);
			Console.BufferWidth = Console.WindowWidth + 1;
			Console.BufferHeight = Console.WindowHeight + 1;
			Console.WriteLine($"Buffer: {Console.BufferWidth}	{Console.BufferHeight}");
			Console.WriteLine($"Window: {Console.WindowWidth}	{Console.WindowHeight}");

			Random rand = new Random();

			int x = rand.Next(Console.WindowWidth - 1);
			int y = rand.Next(Console.WindowHeight - 1);
			Console.CursorVisible = false;
			ConsoleKey key;
			do
			{
				int outOfRange = 0;
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: x++; break;
					default: Console.Beep(500, 500); break;
				}
				if (x < 0) { x = 0; outOfRange++; }
				if (y < 0) { y = 0; outOfRange++; }
				if (x >= Console.WindowWidth - 1) { x = Console.WindowWidth - 1; outOfRange++; }
				if (y >= Console.WindowHeight - 1) { y = Console.WindowHeight - 1; outOfRange++; }
				if (outOfRange > 0) Console.Beep();
				Console.Clear();
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.SetCursorPosition(x, y);
				Console.WriteLine(" ");
				Console.BackgroundColor = ConsoleColor.Black;

				Console.SetCursorPosition(0, 0);
				Console.WriteLine("X = " + x);
				Console.WriteLine("Y = " + y);
				try
				{
				}
				catch (Exception e)
				{
					Console.SetCursorPosition(1, Console.BufferHeight - 2);
					Console.WriteLine(e.Message);
				}
			} while (key != ConsoleKey.Escape);
		}
	}
}
