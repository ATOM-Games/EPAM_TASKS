using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	public struct punckt
	{
		public int X, Y;

		public punckt(int x, int y) { this.X = x; this.Y = y; }

		public void input() {
			Console.Write("X = ");
			X = Int32.Parse(Console.ReadLine());
			Console.Write("Y = ");
			Y = Int32.Parse(Console.ReadLine());
		}

		public override string ToString() => "(" + X + ", " + Y + ")";
	}
}
