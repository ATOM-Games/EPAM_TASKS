using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyString;

namespace Task_2_1
{
	internal class CUSTOM_STRING_2_1_1 : Executable
	{
		public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 2.1.1 Custom string ]<<<--------------]");
			Console.WriteLine("||||| раздел 1 - создание MyCтрок на основе разных типов |||||");
			MyString my_str_str = new MyString("Строка на основе string");
			char[] ch = "Строка на основе char[]".ToCharArray();
			MyString my_str_charArray = new MyString(ch);
			List<char> lc = "Строка на основе листы символов".ToList();
			MyString my_str_charList = new MyString(lc);
			Console.WriteLine(my_str_str);
			Console.WriteLine(my_str_charArray);
			Console.WriteLine(my_str_charList);
			Console.ReadKey();
			Console.WriteLine("||||| раздел 2 - сравнивания |||||");
			Console.WriteLine("Строки " + ((my_str_str == my_str_charArray) ? "равны" : "не равны"));
			Console.WriteLine("Строки " + ((my_str_str == "Строка на основе string") ? "равны" : "не равны"));
			Console.ReadKey();
			Console.WriteLine("||||| раздел 3 - конкантинация (плюсы) |||||");
			MyString res_01 = my_str_str + " ][ " + my_str_charList;
			Console.WriteLine(res_01);
			Console.ReadKey();
			Console.WriteLine("||||| раздел 4 - проверка на символы |||||");
			char r = 'а';
			Console.WriteLine("Символ " + r + " " + ((res_01.isContaint(r)) ? "входит" : "не входит") + " в строку");
			Console.WriteLine("Символ " + r + " входит в строку " + res_01.countContaint(r) + " раз");
			Console.ReadKey();
			Console.WriteLine("||||| раздел 5 - работа с символами |||||");
			MyString prd = new MyString("Предложение 1. предложение еще одно. предложение предложений! еще один Предложение? что-то ТАМ ЕЩЕ.");
			Console.WriteLine("Исходная строка\n[ "+prd+" ]");
			prd.toUpper();
			Console.WriteLine("Upper строка\n[ " + prd + " ]");
			prd.toLower();
			Console.WriteLine("Lower строка\n[ " + prd + " ]");
			prd.toRealUpLow();
			Console.WriteLine("Cтрока с \"правильной\" расстановкой заглавных букв\n[ " + prd + " ]");
			Console.ReadKey();
			Console.WriteLine("||||| раздел 6 - сплиты |||||");
			MyString[] res_02 = prd.Split(' ');
			foreach(MyString s in res_02) { Console.WriteLine(s); }


			Console.ReadKey();
		}
	}
}
