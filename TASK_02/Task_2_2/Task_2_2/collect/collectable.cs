using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	public abstract class collectable : GameObject
	{
		public Map mp;
		public bool onMap = true;

		public collectable(int x, int y, char c) : base(x, y, c) { }

		public void update() {
			if(mp.getPlayer().position.X == position.X && mp.getPlayer().position.Y == position.Y)
			{
				collect(mp.getPlayer());
				onMap = false;
			}
		}
		public abstract void collect(Player plr);
	}
}
