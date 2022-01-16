using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	public abstract class unitable : GameObject
	{
		public unitable(int x, int y, char c) : base(x, y, c) { }
		public void move_up(Map mp)
		{
			if(this.position.Y > 0 && mp.canMove(position.X, position.Y-1))
			{
				this.position.Y--;
			}	
		}
		public void move_down(Map mp)
		{
			if (this.position.Y < mp._mp.GetLength(0)-1 && mp.canMove(position.X, position.Y + 1))
			{
				this.position.Y++;
			}
		}
		public void move_left(Map mp)
		{
			if (this.position.X > 0 && mp.canMove(position.X  - 1, position.Y))
			{
				this.position.X--;
			}
		}
		public void move_right(Map mp)
		{
			if (this.position.X < mp._mp.GetLength(1) - 1 && mp.canMove(position.X + 1, position.Y))
			{
				this.position.X++;
			}
		}

		public abstract void update(ConsoleKeyInfo cki, Map mp);
		public abstract void draw();
	}
}
