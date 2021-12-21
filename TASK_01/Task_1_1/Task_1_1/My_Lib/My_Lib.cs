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
	}
}
