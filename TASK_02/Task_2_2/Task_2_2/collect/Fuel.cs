using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	internal class Fuel : collectable
	{
		public Fuel(int x, int y, Map m) : base(x, y, 'f') {
			this.mp = m;
		}

		public override void collect(Player plr)
		{
			plr.fuel++;
		}
	}
}
