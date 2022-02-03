using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
	class LOWERCASE_1_2_3 : Executable
	{
		public override void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.2.3 Lowercase ]<<<--------------]");
			string str;
			Console.Write("Введите предлоежение : ");
			str = Console.ReadLine();
			Console.WriteLine("---> ариант без *");
			int lowers = 0;
			lowers = str.Split(' ').Select(s => s).Where(s => char.IsLower(s[0])).ToArray().Length;
			Console.WriteLine("Количество слов : "+lowers);
			Console.WriteLine("---> ариант с *");
			lowers = str.Split(My_Lib.sep).Select(s => s).Where(s => s.Length>0 && char.IsLower(s[0])).ToArray().Length;
			Console.WriteLine("Количество слов : " + lowers);




			Console.WriteLine("\n---------------------------\n");
			Console.ReadKey();
		}
	}
}
