using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Circle : Circleference, IareaSizeble
	{
		public double getAreaSize() => Math.PI * radius * radius;

		public override string ToString() => "круг " + center + " радиус " + radius;
	}
}
