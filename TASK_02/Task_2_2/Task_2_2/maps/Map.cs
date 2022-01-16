using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	public class Map
	{
		public char[,] _mp;
		private char[] move_limiters = new char[] { '█', '-', '=' };
		List<unitable> Units = new List<unitable>();
		List<collectable> coll = new List<collectable>();

		public Map() {
			Units.Add(new Player(1, 1));
			Units.Add(new Zombie(10,5));

			coll.Add(new Fuel(12,3, this));
			coll.Add(new Keys(10, 5, this));
			//coll.Add(new Fuel(12, 3, this));
			string[] str = File.ReadAllLines(@"files/map_01.txt");
			this._mp = new char[str.Length, str[0].Length];
			for (int y = 0; y < str.Length; y++) {
				for (int x = 0; x < str[0].Length; _mp[y,x] = str[y][x], x++) ;
			}

		}
		public bool canMove(int x, int y) => (!move_limiters.Contains(_mp[y,x]));
		public char GetChar(int x, int y) {
			if (x >= 0 && x < _mp.GetLength(1) && y >= 0 && y < _mp.GetLength(0)) {
				foreach (unitable u in Units)
				{
					if (u.position.X == x && u.position.Y == y) return u.vid;
				}
				foreach (collectable c in coll)
				{
					if (c.position.X == x && c.position.Y == y) return c.vid;
				}
				return _mp[y, x];
			} else return ' ';
		}

		public void update(ConsoleKeyInfo cki) {
			foreach (unitable U in Units)
			{
				U.update(cki, this);
			}
			foreach (collectable c in coll)
			{
				c.update();
			}
			deleteCollect();
		}

		public Player getPlayer() => (Player)this.Units[0];
		public void deleteCollect() {
			for (int i = 0; i < coll.Count; i++) {
				if (coll[i].onMap == false) { this.coll.Remove(coll[i]); }
			}
		}

	}
}
