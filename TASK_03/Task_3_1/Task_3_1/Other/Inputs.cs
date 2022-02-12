using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
	class Inputs
	{
		public static int int_input_with_while(bool positive, string str) {
			int result = 0;
			do
			{
				Console.Write(str);
				try
				{
					result = Inputs.int_input(positive);
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					continue;
				}
			} while (true);
			return result;
		}

		public static int int_input(bool positive) {
			int result=0;
			try {
				result = int.Parse(Console.ReadLine());
			} catch (Exception ex) {
				throw new Exception("некорректное значение");
			}
			if (positive && result <= 0) {
				throw new Exception("значение должно быть больше 0");
			}
			return result;
		}
	}
}
