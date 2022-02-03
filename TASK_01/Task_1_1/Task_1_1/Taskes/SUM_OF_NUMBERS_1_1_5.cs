using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class SUM_OF_NUMBERS_1_1_5 : Executable
	{
		override public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.5 sum of number ]<<<--------------]");
			int summ = 0;
			for (int i = 3; i < 1000; i++) {
				if (i % 3 == 0 || i % 5 == 0) summ += i;
			}
			Console.WriteLine("Сумма всех чисел (кратных 3 или 5 и меньше 1000) равна : " + summ);
			// - - второй способ без циклов
			int min_3 = 3;
			int max_3 = 999;
			int min_5 = 5;
			int max_5 = 995;
			int min_15 = 15;
			int max_15 = 990;
			double sum = 0;
			sum += (min_3 + max_3) * (max_3 / (float)(2 * min_3));
			sum += (min_5 + max_5) * (max_5 / (float)(2 * min_5));
			sum -= (min_15 + max_15) * (max_15 / (float)(2 * min_3 * min_5));
			Console.WriteLine("Сумма всех чисел (кратных 3 или 5 и меньше 1000) равна : " + sum);
			Console.ReadKey();
		}
	}
}
