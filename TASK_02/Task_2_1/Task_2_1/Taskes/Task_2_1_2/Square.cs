using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Square : Figure , IareaSizeble, Iperimeterable
	{
		public punckt start;
		public int len_A;

		public override void create()
		{
			Console.WriteLine("Введите координаты стартовой точки");
			start.input();
			inputLen();
		}
		public virtual void inputLen() {
			Console.WriteLine("Введите длинну стороны квадрата");
			len_A = int.Parse(Console.ReadLine());
		}

		public override void draw()
		{
			Console.WriteLine(this);
		}
		public override string ToString() => "квадрат со страртовой точкой "+start+" и длиной стороны " + len_A;

		public virtual double getPerimetr() => len_A * 4;

		public virtual double getAreaSize() => len_A * len_A;
	}
}
