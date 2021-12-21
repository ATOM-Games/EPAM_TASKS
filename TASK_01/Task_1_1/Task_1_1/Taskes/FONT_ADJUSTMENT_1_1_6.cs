using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class FONT_ADJUSTMENT_1_1_6
	{
		static public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.6 Font Adjustment ]<<<--------------]");
			string command = "";
			int N = 0, n=0;

			while (true)
			{
				Console.WriteLine("введите параметры записи [ 1 - Bold, 2 - Italic, 3 - Underline ]");
				command = Console.ReadLine();
				if (command == "выход") break;
				n = My_Lib.IntParce(command);
				if (n <= 0 && n > 3) continue;

				N = (isSet(n, N)) ? delNum(n, N) : setNum(n, N);

				Console.WriteLine("[ способ хранения " + N + " ]");

				command = "Параметры текста : ";

				if (N == 0)
					command += " none ";
				if (isSet(1, N)) 
					command += " Bold ";
				if (isSet(2, N))
					command += " Italic ";
				if (isSet(3, N))
					command += " Underline ";

				Console.WriteLine(command);
				Console.WriteLine("\n---------------------------\n");
			}
		}

		static bool isSet(int n, int N) => (N.ToString().Contains(n.ToString()));

		static int setNum(int n, int N) => (N * 10 + n);

		static int delNum(int n, int N) => int.Parse( (N > 10) ? N.ToString().Replace(n.ToString(), string.Empty) : "0" );
	}
}
