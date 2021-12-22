using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
	class VALIDATOR_1_2_4 : Executable
	{

		static char[] endChar = { '.', '!', '?' };
		public override void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.2.4 Validator ]<<<--------------]");
			string str, res="";
			Console.Write("Введите предложения : ");
			str = Console.ReadLine();

			string[] strs = str.Split(endChar).Where(s => s.Length > 0).Select(s => (s[0]==' ') ? char.ToUpper(s[1]).ToString()+s.Remove(0,2) : char.ToUpper(s[0]).ToString() + s.Remove(0, 1)).ToArray();
			
			// далее восстанавливаем знаки в конце строки
			for (int i=0, j=0; i<strs.Length; i++) {
				res += strs[i];
				if (res.Length < str.Length)
				{
					res += str[res.Length]+" ";
				}
			}
			
			Console.WriteLine(res);


			Console.WriteLine("\n---------------------------\n");
			Console.ReadKey();
		}

		
	}
}
