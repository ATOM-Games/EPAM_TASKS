using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class NO_POSITIVE_1_1_8 : Executable
	{
		
		override public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.8 No positive ]<<<--------------]");
			short[,,] qwerty;
			// ↑↑↑↑ в этом самом единственном месте указываем тип массива

			GenerateMassiv(3, 3, 3, out qwerty); // генерируем массив случайных чисел (сохраняя тип массива)
			outputMass(qwerty); // сначала выводим, чтоб убедится, что массив построен

			Console.WriteLine("результат тут ↓↓↓↓");
			zeroDown(qwerty);
			outputMass(qwerty);

			Console.ReadKey();
		}

		void zeroDown<T>(T[,,] mass) where T : IComparable
		{
			
			for (int x = 0; x < mass.GetLength(0); x++)
			{
				for (int y = 0; y < mass.GetLength(1); y++)
				{
					for (int z = 0; z < mass.GetLength(2); z++)
					{
						if (mass[x, y, z].CompareTo(
							(T)(typeof(T).GetMethod("Parse", new[] { typeof(string) }).
								Invoke(obj: typeof(T), parameters: new object[] { "0" }))) > 0) {
							mass[x, y, z] = (T)(typeof(T).GetMethod("Parse", new[] { typeof(string) }).
									Invoke(obj: typeof(T), parameters: new object[] { "0" }));
						}
					}
				}
			}
		}

		void outputMass<T>(T[,,] mass)
		{
			for (int x = 0; x < mass.GetLength(0); x++)
			{
				for (int y = 0; y < mass.GetLength(1); y++)
				{
					for (int z = 0; z < mass.GetLength(2); z++)
					{
						Console.WriteLine(mass[x, y, z]);
					}
				}
			}
			Console.WriteLine($"Тип массива [{mass[0,0,0].GetType()}]");
		}




		void GenerateMassiv<T>(int cx, int cy, int cz, out T[,,] mass)
		{ // метод который принимает массив (любого типа, int long short), и сохраняя тип массива генерит его рандомные значения
			Type t = typeof(T); // получаем тип элемента
			mass = new T[cx, cy, cz]; // создаем массив определенного размера
			if (My_Lib.isDecNum(t))
			{ // проверяем, является ли наш массив чисел (или нет)
				Random rand = new Random(); // ну тут рандом
				Console.WriteLine($"Введите размер рандома (от {t.GetField("MinValue").GetValue(t)} до {t.GetField("MaxValue").GetValue(t)}): "); // выводим максимальный элемент данного типа
				Console.Write("MinValue = ");
				string str = Console.ReadLine(); // ввод с клавиатуры
				if (!(bool)t.GetMethod("TryParse", new[] { typeof(string), t.MakeByRefType() }).Invoke(obj: t, parameters: new object[] { str, null }))
					return;

				int rand_min = System.Convert.ToInt32(
					(T)(t.GetMethod("Parse", new[] { typeof(string) }).Invoke(obj: t, parameters: new object[] { str })) // парсим сохраняя в тип Т
					); // конвертим в int (для рандома)
				Console.Write("MaxValue = ");
				str = Console.ReadLine(); // ввод с клавиатуры
				if (!(bool)t.GetMethod("TryParse", new[] { typeof(string), t.MakeByRefType() }).Invoke(obj: t, parameters: new object[] { str, null }))
					return;
				int rand_max = System.Convert.ToInt32(
					(T)(t.GetMethod("Parse", new[] { typeof(string) }).Invoke(obj: t, parameters: new object[] { str })) // парсим сохраняя в тип Т
					); // конвертим в int (для рандома)

				for (int x = 0; x < cx; x++)
				{
					for (int y = 0; y < cy; y++)
					{
						for (int z = 0; z < cz; z++)
						{
							mass[x, y, z] = (T)(t.GetMethod("Parse", new[] { typeof(string) }).
								Invoke(obj: t, parameters: new object[] { rand.Next(rand_min, rand_max) + "" })); // забиваем наш массив рандомными значениями
						}
					}
				}
			}
			else
			{
				Console.WriteLine("Массив не является численным");
			}
			Console.WriteLine($"Тип элемента массива [ {t} ]");
		}
	}
}
