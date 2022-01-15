using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Rectangle : Square
	{
		int len_B = 0;
		public override void inputLen()
		{
			Console.WriteLine("Введите длинну стороны A");
			len_A = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите длинну стороны B");
			len_B = int.Parse(Console.ReadLine());
		}
		public override string ToString() => "прямоугольник со страртовой точкой " + start + " и длинами сторон " + len_A + " и " + len_B;

		public double getPerimetr() => len_A * 2 + len_B * 2;

		public double getAreaSize() => len_A * len_B;
	}
}
