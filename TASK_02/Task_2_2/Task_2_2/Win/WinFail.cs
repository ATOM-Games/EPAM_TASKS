using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
	internal class WinFail : Windowable
	{
		string message;
		public WinFail(string m) {
			this.message = m;
		}
		int select = 0;
		string[] menu = new string[] {
		"начать заново",
		"главное меню"
		};
		public override void update(ConsoleKeyInfo cki)
		{
			if (cki.Key == ConsoleKey.DownArrow)
			{
				if (select == menu.Length - 1) select = 0;
				else select++;
			}
			if (cki.Key == ConsoleKey.UpArrow)
			{
				if (select == 0) select = menu.Length - 1;
				else select--;
			}
			if (cki.Key == ConsoleKey.Enter) {
				if (select == 0) { Program.win = new GamePlay(); }
				if (select == 1) { Program.win = new MainMenu(); }
			}
		}
		public override void draw()
		{
			for_draw = "╔═════════════════════════════════════════════╗\n";
			for (int yy = 0; yy < wyp; yy++)
			{
				for_draw += "║";
				
				if (yy > ((int)(wyp / 2)) - 1 && yy < ((int)(wyp / 2)) + menu.Length)
				{
					for_draw += new string(' ', 36 - menu[yy - ((int)(wyp / 2))].Length);
					if (select == yy - ((int)(wyp / 2)))
					{
						for_draw += "[ " + menu[yy - ((int)(wyp / 2))] + " ]";
					}
					else
					{
						for_draw += "  " + menu[yy - ((int)(wyp / 2))] + "  ";
					}
				}
				else
				{
					if (yy == 0)
					{
						for_draw += new string(' ', 20 - message.Length / 2);
						for_draw += message;
						for_draw += new string(' ', 20 - message.Length / 2);
					}else
						for_draw += "                                        ";
				}
				for_draw += "     ║\n";
			}
			for_draw += "╚═════════════════════════════════════════════╝\n";
			for_draw += legent();
			Console.WriteLine(for_draw);
		}

		public string legent() => 
"┌─────────────────────┐ ┌─────────────────────┐\n" +
"│(f) fuel :           │ │(X) Player           │\n" +
"│(k) keys :           │ │(Z) Zombie           │\n" +
"│(©) coin :           │ │(M) Mummy            │\n" +
"└─────────────────────┘ └─────────────────────┘";
	}
}