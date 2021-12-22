using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class ARRAY_PROCESSING_1_1_7 : Executable
	{
		override public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.7 Array processing ]<<<--------------]");
			long[] qwerty;
			// ↑↑↑↑ в этом самом единственном месте указываем тип массива



			My_Lib.GenerateMassiv(10, out qwerty); // генерируем массив случайных чисел (сохраняя тип массива)
			Console.WriteLine($"Массив остался старого типа [{qwerty.GetType()}]");
			for (int i = 0; i < qwerty.Length; Console.WriteLine($"---> {qwerty[i]}"), i++) ; // выводим массив, чтоб убедится что он построен

			var (min, max) = MinMax(qwerty); // метод задания 1.1.7
			Console.WriteLine($"Минимальное : {min}, тип [{min.GetType()}]\nМаксимальное : {max}, тип [{min.GetType()}]");
			Console.ReadKey();
		}

		(T min, T max) MinMax<T>(T[] mass) where T : IComparable
		{
			Type t = typeof(T);
			var min = (T)(t.GetField("MaxValue").GetValue(t));
			var max = (T)(t.GetField("MinValue").GetValue(t));

			for (int i = 0; i < mass.Length; i++) {
				if (min.CompareTo(mass[i]) > 0) { min = mass[i]; }
				if (max.CompareTo(mass[i]) < 0) { max = mass[i]; }
			}
			return (min, max);
		}

	}
}
