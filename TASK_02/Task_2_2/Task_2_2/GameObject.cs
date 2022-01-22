using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	public abstract class GameObject
	{
		public point position;
		public char vid;

		public GameObject(int x, int y, char c) {
			this.position.X = x;
			this.position.Y = y;
			this.vid = c;
		}
	}
}
