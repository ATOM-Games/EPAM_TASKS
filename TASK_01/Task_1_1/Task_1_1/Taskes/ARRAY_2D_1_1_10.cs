using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class ARRAY_2D_1_1_10
	{
		static public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.10 2D array ]<<<--------------]");
			int[,] array = new int[5, 5];
			Random rand = new Random();
			for (int y = 0; y< array.GetLength(0); y++) {
				for (int x = 0; x < array.GetLength(1); array[y, x] = rand.Next(10), x++) ;
			}
			outputArray(array);

			int res = summ(array);
			Console.WriteLine("Summ = " + res);
		}

		static void outputArray(int[,] mass) {
			for (int y = 0; y < mass.GetLength(0); y++)
			{
				for (int x = 0; x < mass.GetLength(1); Console.Write(mass[y, x]+ "\t"), x++) ;
				Console.Write("\n");
			}
		}

		static int summ(int[,] mass) {
			int res = 0;
			for (int y = 0; y < mass.GetLength(0); y++) {
				for (int x = y % 2; x < mass.GetLength(1); x += 2) {
					Console.WriteLine($"[ {x} , {y} ]");
					res += mass[y, x];
				}
			}
			return res;
		}
	}
}
