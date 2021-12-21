using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class X_MAS_TREE_1_1_4
	{
		static public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.4 X-Mas tree ]<<<--------------]");
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
		static void OutPutTriangle(int N)
		{
			for (int z = 1; z <= N; z++) {
				for (int s = 1; s <= z; s++) {
					Console.WriteLine(new string(' ', N - s) + new string('*', 2 * s - 1));
				}
			}
		}
	}
}
