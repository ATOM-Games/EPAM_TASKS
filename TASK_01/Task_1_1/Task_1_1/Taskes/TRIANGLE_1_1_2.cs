using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class TRIANGLE_1_1_2 : Executable
	{
		override public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.2 Triangle ]<<<--------------]");
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
			for (int i = 0; i < N; Console.WriteLine(new string('*', i+1)), i++) ;
		}
	}
}
