using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	public class Player : unitable
	{
		public int fuel = 0, keys = 0, coin = 0;

		private Player() : base(0,0,'X') { }
		public Player(int x, int y) : base(x, y, 'X') {}

		public override void update(ConsoleKeyInfo cki, Map mp)
		{
			if (cki.Key == ConsoleKey.UpArrow) move_up(mp);
			if (cki.Key == ConsoleKey.DownArrow) move_down(mp);
			if (cki.Key == ConsoleKey.LeftArrow) move_left(mp);
			if (cki.Key == ConsoleKey.RightArrow) move_right(mp);
		}
		public override void draw()
		{
			
		}
	}
}
