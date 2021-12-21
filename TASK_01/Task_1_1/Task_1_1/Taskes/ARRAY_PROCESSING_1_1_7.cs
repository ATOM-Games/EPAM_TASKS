using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class ARRAY_PROCESSING_1_1_7
	{
		static public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.7 Array processing ]<<<--------------]");
			short[] qwerty;
			GenerateMassiv(10, out qwerty);




		}

		static void GenerateMassiv<T>(int count, out T[] mass) {
			Type t = typeof(T);
			mass = new T[count];
			Random r = new Random();
			Console.WriteLine($"Введите размер рандома (от 0 до ): ");
			Console.WriteLine(t);




			Console.WriteLine();

			//for (int i = 0; i < count; mass[i] = r.Next(100), i++) ;
		}
	}
}
