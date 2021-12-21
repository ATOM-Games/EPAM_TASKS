using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class My_Lib
	{
		static public void InputValue(ref int z, ref string com, char zname)
		{ // метод для ввода с клавиатуры
			Console.Write($"Введите число {zname} (для выходa напишите \"выход\")\n---> ");
			com = Console.ReadLine();
			if (com == "выход") return;
			z = IntParce(com);
		}

		static public int IntParce(string str)
		{ // метод, который парсит строчку
			int res = 0;
			if (!Int32.TryParse(str, out res))
			{
				Console.WriteLine("ERROR!! некорректное число");
				return 0;
			}
			return res;
		}

		static public bool isDecNum(Type t)
		{
			switch (Type.GetTypeCode(t))
			{
				case TypeCode.Byte:
				case TypeCode.SByte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Decimal:
				case TypeCode.Double:
				case TypeCode.Single:
					return true;
				default:
					return false;
			}
		}
		
		static public void GenerateMassiv<T>(int count, out T[] mass)
		{ // метод который принимает массив (любого типа, int long short), и сохраняя тип массива генерит его рандомные значения
			Type t = typeof(T); // получаем тип элемента
			mass = new T[count]; // создаем массив определенного размера
			if (isDecNum(t))
			{ // проверяем, является ли наш массив чисел (или нет)
				Random rand = new Random(); // ну тут рандом
				Console.WriteLine($"Введите размер рандома (от {t.GetField("MinValue").GetValue(t)} до {t.GetField("MaxValue").GetValue(t)}): "); // выводим максимальный элемент данного типа

				Console.Write("MinValue = ");
				string str = Console.ReadLine(); // ввод с клавиатуры
				if (!(bool)t.GetMethod("TryParse", new[] { typeof(string), t.MakeByRefType() }).Invoke(obj: t, parameters: new object[] { str, null }))
					return;
				
				int r_min = System.Convert.ToInt32(
					(T)(t.GetMethod("Parse", new[] { typeof(string) }).Invoke(obj: t, parameters: new object[] { str }))
					); // конвертим в int (для рандома)

				Console.Write("MaxValue = ");
				str = Console.ReadLine(); // ввод с клавиатуры
				if (!(bool)t.GetMethod("TryParse", new[] { typeof(string), t.MakeByRefType() }).Invoke(obj: t, parameters: new object[] { str, null }))
					return;

				int r_max = System.Convert.ToInt32(
					(T)(t.GetMethod("Parse", new[] { typeof(string) }).Invoke(obj: t, parameters: new object[] { str }))
					); // конвертим в int (для рандома)

				for (int i = 0; i < count; i++)
				{
					mass[i] = (T)(t.GetMethod("Parse", new[] { typeof(string) }).
					Invoke(obj: t, parameters: new object[] { rand.Next(r_min, r_max) + "" })); // забиваем наш массив рандомными значениями
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
