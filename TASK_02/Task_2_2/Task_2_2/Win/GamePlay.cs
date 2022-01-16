using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	internal class GamePlay : Windowable
	{
		Map mp;

		public GamePlay() {
			mp = new Map();
		}

		public override void update(ConsoleKeyInfo cki)
		{
			mp.update(cki);
		}
		
		int xp = (int)(wxp / 2), yp = (int)(wyp / 2);
		public override void draw()
		{
			for_draw = "╔═════════════════════════════════════════════╗\n";
			for (int yy = 0; yy < wyp; yy++) {
				for_draw += "║";
				for (int xx = 0; xx < wxp; xx++)
				{
					for_draw += mp.GetChar(xx - (xp - mp.getPlayer().position.X), yy - (yp - mp.getPlayer().position.Y));
				}
				for_draw += "║\n";
			}
			for_draw += "╚═════════════════════════════════════════════╝\n";
			for_draw += legent();
			Console.WriteLine(for_draw);
		}

		public string legent() => "┌─────────────────────┐ ┌─────────────────────┐\n" +
"│(f) fuel : "+mp.getPlayer().fuel+"	      │ │(X) Player           │\n" +
"│(k) keys : "+mp.getPlayer().keys+"	      │ │(Z) Zombie           │\n" +
"│(©) coin : "+mp.getPlayer().coin+"	      │ │(M) Mummy            │\n" +
"└─────────────────────┘ └─────────────────────┘";
	}
}
