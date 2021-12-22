using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
	class DOUBLER_1_2_2 : Executable
	{
		public override void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.2.2 Doubler ]<<<--------------]");
			string str_1, str_2, res="";
			Console.Write("Введите строку 1 : ");
			str_1 = Console.ReadLine();
			Console.Write("Введите строку 2 : ");
			str_2 = Console.ReadLine();
			str_2 = new string(str_2.Replace(" ", null).ToCharArray().Distinct().ToArray()); // массив в множество символов (убираем ПОВТОРЯЮЩИЕСЯ БУКВЫ из второй строки)

			for (int i = 0; i < str_1.Length; i++) {
				res += (str_2.Contains(str_1[i])) ? str_1[i].ToString() + str_1[i].ToString() : str_1[i].ToString();
			}
			Console.WriteLine($"Результирующая строка : {res}");

			Console.WriteLine("\n---------------------------\n");
			Console.ReadKey();
		}
	}
}
