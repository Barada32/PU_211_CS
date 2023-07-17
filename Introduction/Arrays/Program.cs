using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			//Heap - куча (Динамическая память)
			//System.Array

			//		type[] name = new type[size];
			//		type[] name = new type[size] {init_values};
			//int[] arr = new int[] { 3, 5, 8, 13, 21 };
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new int[n];
			int[] arr;
			arr = new int[n];
			//Заполнение массива случайными числами:
			//1) Создаем объект класса Random:
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}

			//Вывод массива на экран:
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			//Сумма
			//Среднее-арифметическое
			//Миниматьное
			//Максимальное
			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметичесое элементов массива: {arr.Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");

			Array.Sort(arr);

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();

			arr = arr.Concat(new int[] { 123 }).ToArray();
			foreach (int i in arr) Console.Write(i + "\t"); Console.WriteLine();
		}
	}
}
