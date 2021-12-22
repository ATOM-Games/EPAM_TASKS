using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
	class AVERAGES_1_2_1 : Executable
	{
		public override void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.2.1 Averages ]<<<--------------]");
			string str = "";
			do {
				Console.WriteLine("Введите предложение (\"выход\" для завершения работы)");
				str = Console.ReadLine();
				int[] lenghts_of_world = str.Split(My_Lib.sep).Where(s=>s.Length>0).Select(s=>s.Length).ToArray(); // массив слов превращаем в массив длин слов
				double sr = 0;
				lenghts_of_world.Select(s=>sr+=s).ToArray();
				sr /= lenghts_of_world.Length;
				Console.WriteLine($"Средняя длина (без огругления) слова в введенной строке : {sr}");
				for (int i = 0; i < lenghts_of_world.Length; Console.Write(lenghts_of_world[i]+" "), i++) ;
				Console.WriteLine("");
			} while (str != "выход");
			Console.WriteLine("\n---------------------------\n");
		}
	}
}
