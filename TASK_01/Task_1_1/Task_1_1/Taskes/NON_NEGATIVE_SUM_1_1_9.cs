using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1
{
	class NON_NEGATIVE_SUM_1_1_9
	{
		static public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 1.1.9 Non negative sum ]<<<--------------]");
			int[] qwerty;

			My_Lib.GenerateMassiv(10, out qwerty);
			for (int i = 0; i < qwerty.Length; Console.WriteLine(qwerty[i]), i++) ;
			Console.WriteLine($"Тип элемента [{qwerty[0].GetType()}]");



			var res = sumNonPositive(qwerty);
			Console.WriteLine($"Ответ {res} тип [{res.GetType()}]");

		}

		static T sumNonPositive<T>(T[] mass) where T : struct, IComparable {
			var sum = default(T);

			for (int i = 0; i < mass.Length; i++) {

				if (mass[i].CompareTo(0) < 0) {
					var j = (dynamic)sum + (dynamic)mass[i];
					sum = j;
				}
			}
			return sum;
		}
	}
}
