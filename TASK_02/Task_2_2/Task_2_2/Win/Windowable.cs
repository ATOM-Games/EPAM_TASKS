using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	public abstract class Windowable
	{
		public static int wxp = 45, wyp = 15;
		protected string for_draw;
		public abstract void update(ConsoleKeyInfo cki);
		public abstract void draw();
	}
}
