using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	internal class Zombie : unitable
	{
		public Zombie(int x, int y) : base(x, y, 'Z') { }
		public override void update(ConsoleKeyInfo cki, Map mp)
		{
			if (this.position.X > mp.getPlayer().position.X) this.move_left(mp);
			if (this.position.X < mp.getPlayer().position.X) this.move_right(mp);
			if (this.position.Y > mp.getPlayer().position.Y) this.move_up(mp);
			if (this.position.Y < mp.getPlayer().position.Y) this.move_down(mp);

			if (this.position.X == mp.getPlayer().position.X && this.position.Y == mp.getPlayer().position.Y) {
				Program.win = new WinFail("Вы проиграли");
			}

		}
		public override void draw()
		{

		}
	}
}
