using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Circleference : Figure, Iperimeterable
	{
		public punckt center;
		public int radius;


		public override void create()
		{
			inputCenter();
			inputRadius();
		}
		public void inputCenter() {
			Console.WriteLine("Введите координаты центра");
			center.input();
		}
		public virtual void inputRadius() {
			Console.Write("Pадиус = ");
			radius = Int32.Parse(Console.ReadLine());
		}

		public override void draw()
		{
			Console.WriteLine(this);
		}
		public override string ToString() => "окружность " + center + " радиус " + radius;

		public double getPerimetr() => 2 * Math.PI * radius;
	}
}
