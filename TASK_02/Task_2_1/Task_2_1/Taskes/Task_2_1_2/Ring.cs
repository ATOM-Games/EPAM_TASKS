using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Ring : Circle, IareaSizeble, Iperimeterable
	{
		public int outRadius;

		public Ring() {}

		public override void inputRadius()
		{
			Console.Write("Внутренний радиус = ");
			radius = Int32.Parse(Console.ReadLine());
			Console.Write("Внешний радиус = ");
			outRadius = Int32.Parse(Console.ReadLine());
		}

		public override string ToString() => "кольцо " + center + " внутренний радиус " + radius + " внешний радиус "+outRadius;

		public double getAreaSize() => Math.PI * outRadius * outRadius - base.getAreaSize();

		public double getPerimetr() => 2 * Math.PI * outRadius;
	}
}
