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
			Console.CursorTop = 10;
			Console.CursorLeft = 10;
			Console.CursorVisible = false;
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.W:	Console.CursorTop++; break;
					case ConsoleKey.S:	Console.CursorTop--; break;
					case ConsoleKey.A:	Console.CursorLeft--;break;
					case ConsoleKey.D:	Console.CursorLeft++;break;
					default: Console.Beep();break;
				}
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.WriteLine(" ");
				Console.BackgroundColor = ConsoleColor.Black; 
			} while (key != ConsoleKey.Escape);
		}
	}
}
