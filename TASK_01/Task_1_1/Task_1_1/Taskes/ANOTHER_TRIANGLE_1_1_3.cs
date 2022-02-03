using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class ANOTHER_TRIANGLE_1_1_3 : Executable
	{
		override public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.3 Аnother Triangle ]<<<--------------]");
			string command = "";
			int N = 0;

			while (true)
			{
				My_Lib.InputValue(ref N, ref command, 'N');
				if (command == "выход") break;
				if (N <= 0) continue;
				OutPutTriangle(N);
				Console.WriteLine("\n---------------------------\n");
			}
		}
		void OutPutTriangle(int N) {
			for (int z = 1; z <= N; z++) {
				Console.WriteLine(new string(' ', N - z) + new string('*', 2 * z - 1));
			}
		}
	}
}
