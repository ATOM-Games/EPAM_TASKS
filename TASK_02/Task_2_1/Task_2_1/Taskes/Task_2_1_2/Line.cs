using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Line : Figure
	{
		public punckt A, B;

		public override void create()
		{
			Console.WriteLine("Введите координаты точки А");
			A.input();
			Console.WriteLine("Введите координаты точки В");
			B.input();
		}

		public override void draw()
		{
			Console.WriteLine(this);
		}
		public override string ToString() => "линия А = " + A + " B = " + B;
	}
}
