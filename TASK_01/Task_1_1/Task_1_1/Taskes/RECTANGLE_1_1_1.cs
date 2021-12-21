using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class RECTANGLE_1_1_1
	{
		static public void Execute() {
			Console.WriteLine("[-------------->>>[ 1.1.1 Rectangle ]<<<--------------]");
			string command = "";
			int X = 0, Y = 0, Res = 0;
			while (true) {
				My_Lib.InputValue(ref X, ref command, 'X');
				if (command == "выход") break;
				if (X == 0) continue;
				My_Lib.InputValue(ref Y, ref command, 'Y');
				if (command == "выход") break;
				if (Y == 0) continue;

				Res = Rectangle(X, Y);
				Console.WriteLine($"Площадь прямоугольника ({X}, {Y}) равна {Res}");
				Console.WriteLine("\n---------------------------\n");
			} 
		}

		static int Rectangle(int x, int y) => x * y; // метод, подсчитывающий площадь
	}
}
